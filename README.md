# Android HARP For Rokid X-Craft

---

## Installation of Necessary Softwares/Toolkits/Packages/Dependencies/SDK

### Getting the required Assets
Git Clone / Pull or Download as Zip in the following GitHub Repository

### Installation of Window SDK
Install the Window SDK (Version 10.0.19041.0) needed for Hololens 2. Click [here](https://go.microsoft.com/fwlink/?linkid=2120843) to download if not find the references [here](https://developer.microsoft.com/en-us/windows/downloads/sdk-archive/)

### Installation of Unity Hub
Unity Hub is required to open or run any of the Unity Projects. You can install them by clicking [here](https://public-cdn.cloud.unity3d.com/hub/prod/UnityHubSetup.exe) if not visit the official website [here](https://unity3d.com/get-unity/download)

### Choose your appropriate Unity Version that you need.
For this case we're using **2020.3.33f1** where you can find all the archive [here](https://unity3d.com/get-unity/download/archive)

Modules needed for Unity 2020.3.33f1 to Develop in Hololens 2
- Universal Windows Platform Build Support
- Windows Build Support
- Visual Studio (VS Community 2022 / 2019)

![image](https://user-images.githubusercontent.com/25051402/201806064-b90d99e9-ae9a-4ba3-bff0-f3c956019f6e.png)
![image](https://user-images.githubusercontent.com/25051402/201806166-feb51ed6-af68-427a-b5cd-2b279643137e.png)
![image](https://raw.githubusercontent.com/21047599-Tan-Yao-Rong/LtaAndroidHARP/main/New.png)

### Choose the Visual Studio you prefer to use
Tested with VS Community 2022 and VS Commmunity 2019. You can find these [here](https://visualstudio.microsoft.com/downloads/)

Go to Visual Studio Installer and Download the Necessary Workloads Stated Below

Under Desktop & Mobile Section
- Universal Windows Platform Development
- .NET Desktop Development
- Desktop Development with C++
![image](https://user-images.githubusercontent.com/25051402/201803875-bfa8e8e3-a7d1-469f-b146-a69d337741cd.png)

Under Gaming
- Game Development with Unity
- Game development with C++ 
![image](https://user-images.githubusercontent.com/25051402/201804092-12f338fd-ff86-4305-af80-c1b1605f9223.png)

### Rokid UXR SDK
- [UXR SDK Download](https://ota-g.rokidcdn.com/toB/Rokid_Glass/SDK/UXR_SDK/Unity/forDock/RokidUXR_Unity_ForDock_v1.6.2.zip)
  
---

## Problems faced when only using HARP in HoloLens
- Current limitations in our testing environment stem from the exclusive reliance on Hololens, no other alternative devices with other capability to use.

- Deployment of HARP, which is developed specifically for Hololens, on other devices is currently unfeasible as HARP is only created on Windows Operating system

## Objective of porting over HARP from Hololens to Rokid
- Expand our testing capabilities

- Explore the compatibility of HARP with various Android devices

- Optimize HARP for the different hardware in Rokid
 
---
## Architecture diagram
![Untitled Diagram drawio (4)](https://raw.githubusercontent.com/21047599-Tan-Yao-Rong/LtaAndroidHARP/main/Screenshot%202023-10-18%20160700.png)

---
## Main Components of HARP

- User Interface
- Photon
- AR Frameworks
- Cloud Services
- Applications
- User Input

---
## Setting up the Working Environment from Downloaded Asset

### Opening Unity Project

1) Open Unity Hub
2) Open Project -> Select Downloaded Project

## Setting up the Working Environment from Scratch

### Creating the Project

1) Open Unity Hub
2) New Project -> 3D (Core)

## Installing and Importing Packages in Unity

Step 1: In a new project, choose Windows > Package Manager and select "+" > Add package from disk. Then [download](https://ota-g.rokidcdn.com/toB/Rokid_Glass/SDK/UXR_SDK/Unity/forDock/RokidUXR_Unity_ForDock_v1.6.2.zip) and unzip the package.json file under the RokidUXR_SDK_Unity_ForDock/sxrunitysdk-UXR_vdock directory, and import the Google Cardboard plug-in.

![image](https://raw.githubusercontent.com/21047599-Tan-Yao-Rong/LtaAndroidHARP/main/image.png)

Step 2: Choose Unity > Assets > Import Package > Custom Package, select UXR_Dock_v.unitypackage in the UXR SDK, and import all resources.
 Tips:  The version number is in X.Y.Z format. (For exampe, 1.1.0).

 ![image](https://raw.githubusercontent.com/21047599-Tan-Yao-Rong/LtaAndroidHARP/main/Step%202.1.png)
 ![image](https://raw.githubusercontent.com/21047599-Tan-Yao-Rong/LtaAndroidHARP/main/Step2.2.png)

---
## Code walkthrough / explanation 

UploadToDrive.cs 
- Contain codes that allows connection to One drive using APIs, it detects what is checked/unchecked in the checkList and converts them into JSON format after that it is send into one drive & contain codes to allow the files to be saved locally

TodoClose.cs & OpenCheckList.cs
- The script that provides codes to open the checkList and to close the checkList

ScrollMainMenu.cs
- The script contains codes that provides the function for the user to scroll up and down in the main menu and select the applications in the main menu

VoiceMainMenu.cs
- The script contain codes that provides allows the user to use voice command to activate features like "going into checkList App" etc.

HandGestureMainMenu.cs
- The script contain codes that allows the user's hand gesture to be detected by Rokid, there is 3 different gesture that is being used, "Open palm" "Close palm" "Pinch" . Close palm will move the hand Menu around, Pinch is like a select Button. Open palm is for navigating using hand gestures.

RayCaster.cs
- The script contains a RayCast which is able to detect what the user's hand gesture is pointing at and provides the input for the HandGesture Script

SceneLoader.cs
- The script contain what scene is to be loaded when it is selected.

FaceDetect.cs 
- Contains code that opens up the Camera in the device, the photo data is send to the Face Detect API, the photo data will be processed and results will be given

ObjectDetect.cs
- Contains code that opens up the Camera in the device, the photo data is send to the Object Detect API, the photo data will be processed and results will be given

ClickedDocument.cs
- The script contains the code that links the document viewer in Rokid and it will open up the document viewer when the script is called

ClickedQRScanner.cs
- The script contains the code that links the QR scanner in Rokid and it will open up the QR scanner when the script is called, the QR code that has been scanned will be send back to the script and a google chrome will open using the QR code that has been scanned

### Switching Platform to Android

Go to File -> Build Setting -> Android

If not Downloaded, Download in Unity Editor and Restart the Project

### Disable Compression Format

1) Go to File -> Build Settings -> Player Settings
![image](https://user-images.githubusercontent.com/25051402/209916303-b1eee72e-7d6f-4247-b259-fe19e5b264ec.png)
2) Go to Player -> Publishing Settings
3) Under Compression Format -> Select Disabled
![image](https://user-images.githubusercontent.com/25051402/209916468-305da456-01d2-469c-bf6a-e2f6e21415a0.png)

---
## Testing & Deploying

For Testing, just press play in Unity.

![image](https://user-images.githubusercontent.com/25051402/209916155-7e40f7d6-c903-48ad-be9b-ffde3bf23a8d.png)

To test how it looks on WebPage, 
Click File -> Build Setting -> Select WebGL -> Build and Run

![image](https://user-images.githubusercontent.com/25051402/209916109-94901c68-c116-451c-970f-a46e2f650f19.png)

For Deploying, Zip the file and upload to [itch.io](itch.io)

1) Log-in with the following email and password, taamgame@gmail.com | ActiveMobility123
2) Navigate to the drop down arrow located at the top right and upload project

![image](https://github.com/20145050-Vernon-Ong/Active-Mobility-Game/assets/104333224/95601ba0-a4d2-496c-991e-4dd13db3e99f)

3) You can then fill up the basic information of the game and upload the project onto itch for testing

![image](https://github.com/20145050-Vernon-Ong/Active-Mobility-Game/assets/104333224/b09616bd-5646-41ce-a82a-729396a9ce33)

---
## Update or manage Leaderboard

You can manage the leaderboard by accessing it through this link: [Leaderboard Creator by Danial Jumagaliyev (itch.io)](https://danqzq.itch.io/leaderboard-creator). You can then choose to either Create a new leaderboard or make use of existing leaderboards. 

![image](https://github.com/20145050-Vernon-Ong/Active-Mobility-Game/assets/104333224/df1ef533-ab82-41fe-bef0-a0e9c48dc63c)

If you would like to add the existing leaderboard into the site, you just have to copy the string of key located in leaderboard.cs. and paste it in.

![image](https://github.com/20145050-Vernon-Ong/Active-Mobility-Game/assets/104333224/23e903b1-dea5-49d4-aace-5a618dc0fd6e)

If you choose to add a new leaderboard you can do so but if you want the game to make use of the newly created leaderboard, you would have to copy the secret key and replace the string of key located in leaderboard.cs

private string publicLeaderboardKey = "9adf1b039fb92837c0a268411dd78ff70a7820d1734da55b9640cdcf9f7561fa";

---
## Update or Create new maps through the 2DTiledMap application 

1) 	In Tiled, click File located at the top-left corner, hover over New and select New Map.
   
![image](https://github.com/20145050-Vernon-Ong/Active-Mobility-Game/assets/104333224/ec075be5-c259-4cda-b543-bb3af3859e03)

![image](https://github.com/20145050-Vernon-Ong/Active-Mobility-Game/assets/104333224/043d69e0-43fe-4386-8792-aab08eac3d59)

2) 	Map properties should be based on the image shown and save the map into "MapWithColliders".
   
![image](https://github.com/20145050-Vernon-Ong/Active-Mobility-Game/assets/104333224/a3b29bd5-f04d-48ec-a0a7-257fa5be3162)

### Adding a new scene for the new level and inserting the newly created map.

1) In Unity, under Project located at bottom left corner, proceed into the Scene folder. Once in it, right-click and hover over Create. Select Scene to create a new scene. This can be called “Level 2” or any suitable names.
   
![image](https://github.com/20145050-Vernon-Ong/Active-Mobility-Game/assets/104333224/6c528572-0071-4ebd-bf49-40257b25dd76)

![image](https://github.com/20145050-Vernon-Ong/Active-Mobility-Game/assets/104333224/8cae9d75-a63a-4cd6-a2fc-c3b0e3ab8c7a)

2) To add a new map from Tiled, double click the newly created scene to be in that specific scene. Once done, find the map created and saved previously into the folder and drag it into the scene.
   
![image](https://github.com/20145050-Vernon-Ong/Active-Mobility-Game/assets/104333224/ba448f65-2f0a-4dd9-9cda-3d231e40375d)

3) To update the map, follow along the Demo1 video.

### Stage/Levels, Moving from one scene to another with the use of buttons.

1) To create a button in Unity, under the GameObject menu, hover to UI and click Button – TextMeshPro.
2) For the scene that wants to be displayed, ensure it is added to “Scenes In Build” located in Build Settings.
3) Using the MapLoaderScript.loadScene, input the scene number assigned in the Build Settings to load the respective map/level.

![image](https://github.com/20145050-Vernon-Ong/Active-Mobility-Game/assets/104333224/01a5c1bb-5d01-49cb-898c-9d50660cbf5e)

Refer to demo2 video.

### Updating UI with new graphics.

1) To update the UI for the game, head over to the Hierarchy of the unity project and look for canvas.
   
![image](https://github.com/20145050-Vernon-Ong/Active-Mobility-Game/assets/104333224/060fc08d-cd85-4a58-9ce4-51cc4285a329)

2) To change the graphics for the player information at the top left, you can edit the playerinfo prefab located in the hierachy.
3) you can then edit any of the prefab with images under the inspector.

![image](https://github.com/20145050-Vernon-Ong/Active-Mobility-Game/assets/104333224/29ceef97-fbbe-4688-889f-06f25f398db1)

4) The notable UI are PlayerInfo, NotifPop, TutorialPop, Popup, PauseMenu, D-Pad and any buttons or texts found in the canvas hierarchy.
   
---
## Extra guide

- [Tiled](https://www.youtube.com/watch?v=ZwaomOYGuYo&list=PL6wuv1YGOTFfxi8pdN2ghWmDqZqy3_XA7)
- [Aseprite](https://www.youtube.com/watch?v=tFsETEP01k8)
- [Unity Web Game](https://youtube.com/playlist?list=PL4vbr3u7UKWp0iM1WIfRjCDTI03u43Zfu)
- [Leaderboard Guide](https://youtu.be/-O7zeq7xMLw?si=kUbx0BF7NEU8RBM_)
- To use tilemap in unity directly instead of using [Tiled](https://www.mapeditor.org/). Refer [here](https://www.youtube.com/watch?v=ryISV_nH8qw&t=627s)
- Collison and Layer Sorting using [Tiled](https://www.mapeditor.org/) and Unity. Refer [here](https://www.youtube.com/watch?v=iJINzMUxlkA&t=220s)
- [Level framework](https://forum.unity.com/threads/progression-xp-points-leveling-framework.428087/)
- [Level/Stage selection](https://youtu.be/YAHFnF2MRsE?si=r_Z3f4p57ePkSTWq) and [here](https://youtu.be/vpbPd6jNEBs?si=snZCrgQ_oCNPmw6k)

## Quick Guide on Creating Boundaries

![image](https://user-images.githubusercontent.com/25051402/210027918-6126524c-4a9e-40b3-8784-d9bde1885c7e.png)
![image](https://user-images.githubusercontent.com/25051402/210028050-8cb97f71-7022-463b-a803-9bd616c1ed7a.png)

Remember to save after adding borders to your tileset Asset
