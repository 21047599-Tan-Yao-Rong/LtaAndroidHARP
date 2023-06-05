using UnityEngine;
using UnityEngine.SceneManagement;
using Microsoft.MixedReality.Toolkit;

public class ClickedDocument : MonoBehaviour
{
    //public int Sceneindex;

    private bool m_Enter = false;

    public void OnPointerEnter()
    {
        m_Enter = true;
        VoiceCommandLogic.Instance.AddInstrucEntityZH("打开", "da kai", true, true, true, this.gameObject.name, "Open", "打开");
    }

    public void OnPointerExit()
    {
        m_Enter = false;
        VoiceCommandLogic.Instance.RemoveInstructZH("打开");
    }

    private void Update()
    {
        if (!m_Enter) return;
        //if (Application.platform == RuntimePlatform.Android)
        //{
            if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Return))
            {
            OpenFileExplorer();
        }
        //}
    }

    private void Open()//for voice command
    {
        VoiceCommandLogic.Instance.RemoveInstructZH("打开");
    }

    private async void OpenFileExplorer()
    {
    var path = Application.persistentDataPath;
    #if UNITY_ANDROID && !UNITY_EDITOR
            using (var unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            {
                var currentActivity = unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");
                using (var intentClass = new AndroidJavaClass("android.content.Intent"))
                {
                    var intentObject = new AndroidJavaObject("android.content.Intent", intentClass.GetStatic<string>("ACTION_OPEN_DOCUMENT_TREE"));
                    intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_ALLOW_MULTIPLE"), true);
                    intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_LOCAL_ONLY"), true);
                    currentActivity.Call("startActivityForResult", intentObject, 0);
                }
            }
    #else
    System.Diagnostics.Process.Start("explorer.exe", path);
    #endif
    VoiceCommandLogic.Instance.RemoveInstructZH("打开");
    }
}