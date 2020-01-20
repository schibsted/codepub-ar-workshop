
# Workshop
## Vuforia basics
1. Create a Vuforia license key
    1. Go to developer.vuforia.com
    1. On the *Develop* page, go to *License Manager* and click *Get Development Key*
    1. Enter any name and confirm
    1. Click the newly created license and copy the long license key  
    1. In Unity open the `Resources` folder in the *Project* view on the bottom of the screen. Select `VuforiaConfiguration` and paste in your license key from into the license key field in the inspector on the right side of the screen.

1. Create an target database
    1. Back on developer.vuforia.com, go to *Target Manager* and click *Add Database*
    1. Set any name for the database, make sure type is set to *Device*
    1. Select the newly created database and click *Add Target*
    1. Make sure *Single Image* is selected and choose the file, you can find the image markers in the folder *targets*
    1. Set the width to *1* and set a name
    1. Repeat for all of the targets in the folder
    1. When you've uploaded all of the targets, click *Download Database (All)* and make sure to change the format to Unity
    1. Open the downloaded database to import it into Unity (alternatively you can drag and drop it into Unity)

1. Display a cube on the marker
    1. Create a new scene
    1. Save the scene and don't forget to save as you add things
    1. Remove all of the objects in the scene except the `Directional Light`
    1. Add an `ARCamera` *(GameObject -> Vuforia -> ARCamera)*
    1. Add an `ImageTarget` *(GameObject -> Vuforia -> Image)*
    1. Set the image target you want to track in the *Inspector* panel on the right, look for *Image Target Behaviour (Script)* and make sure *Database* is set to the database you created and *Image Target* to the target you want to track.  
    1. Add a cube model by right clicking on the `ImageTarget` in the *Hierarchy* panel on the left and selecting *3D object -> Cube*.
    1. Scale the cube to the size you want (either with the scale tool or in the *Inspector* on the right)
    1. Click the *Play* icon on the top of the screen to test your game. You should see the image through your webcam. Place your marker into the view of the camera cube should appear on the camera.

## Make the mini golf game
1. Create the ball pitch
    1. Create a new `ImageTarget` (or use the previous one with the cube, but remove the cube)
    1. Add a ball pitch model by opening the `Prefabs` folder in the *Project* panel on the bottom and dragging the `BallPitch` prefab onto your new image target in the *Hierarchy* panel on the left
    1. Add a ground by repeating the above for the `Ground` prefab
    1. Add an empty game object to act as the position for new balls to spawn by right clicking on the `ImageTarget` and selecting *Create empty*
    1. Rename the new GameObject to `BallSpawnPosition` or similar
    1. Move the `BallSpawnPosition` slightly upward in the 3D view so the balls will spawn above the platform not inside of it
    1. Select the `BallPitch` object and add the `BallPitch` script to it by clicking *Add Component* in the *Inspector* on the right and typing *Ball Pitch* into the search box and then clicking the found script.
    1. Set the `Ball` prefab as the ball to spawn by dragging it from the `Prefabs` folder and dropping it on the `Ball Prefab` field in the *Inspector*
    1. Set the `BallSpawnPosition` as the position where to spawn the balls by dragging and dropping it on the `Ball Spawn Point` field
    1. Test the game again by pressing *Play*, now the ball pitch should appear on the marker

  1. Add a button to spawn a ball
      1. Create a new button by selecting *GameObject -> UI -> Button* in the toolbar, this will create a few GameObjects in your scene needed for the UI and a button as a child of the `Canvas` object
      1. Switch to 2D orthogonal view to make it easier to work with the UI by clicking the small *2D* button on top of the 3D view
      1. Zoom in on the button by double clicking on the newly created button object in the *Hierarchy* panel on the left
      1. Zoom out enough that you can see a white rectangle which represents the edges of the screen
      1. Position the button where you want it to be (use the *Rect tool*)
      1. You should anchor the button to a side of the screen, probably the bottom. You can do this in the *Inspector* on the right, with the button selected, click the triple rectangle thing and click one of the side rectangles in the middle where theres a 3x3 grid of rectangles showing
      1. Add the `LongPressButton` script to the button by scrolling to the bottom of the inspector and clicking *Add Component* and searching for `Long press button`
      1. Set the `Ball Pitch` field of the script by dragging and dropping the `BallPitch` object on the field on the script
      1. You can now test the game, press *Play* and see if the button appears where you want it. With the ball pitch marker in view, press the button once to spawn a new ball and then long press to shoot the ball. The longer you press the stronger the shot will be.

  1. Create the obstacles
      1. Add an new `ImageTarget` (*GameObject -> Vuforia -> Image* in the toolbar)
      1. Move it a bit to the side in the 3D view, the position doesn't matter, it's just so it doesn't overlap with the ball pitch one so it's easier to see them
      1. Set which image you want this target to track in the *Inspector* on the right
      1. Add the `Hole` prefab as a child of the ImageTarget by dragging and dropping it from the `Prefabs` folder onto the new ImageTarget in the *Hierarchy* panel
      1. You can test the game again and see if the hole displays on the marker
      1. Repeat for the other obstacles in the `Prefabs` folder (`Ramp` and `CornerRamp`)

## Installing the game on your device
### Android
1. On your phone, open the settings and go to *About phone* or similar, tap 5 times on the *Build Number*. You should see a toast counting down and saying *Congratulations, you are now a developer!*
1. Plug the phone into the computer, you should get a popup on the phone asking you if you trust this device, say yes
1. Open the Build Settings (*File -> Build Settings*)
1. Click on *Add open scenes* to add your scene to the build. The scene on top will be the one that gets opened when the app is opened, so if your scene is not on top drag it to the top
1. Select *Android* on the list and click `Switch Platform`, this can take a moment
1. Click `Build And Run`, give the file a name and place in anywhere you want on your computer. Unity should now build the project into a `.apk` and automatically install it on your phone.

### iOS
1. Start *XCode* and install any additional components if prompted
1. Plug you phone into the computer
1. Back in Unity, open the Build Settings (*File -> Build Settings*)
1. Click on *Add open scenes* to add your scene to the build. The scene on top will be the one that gets opened when the app is opened, so if your scene is not on top drag it to the top
1. Select *iOS* on the list and click `Switch Platform`, this can take a moment
1. Click `Build And Run`, give the folder a name and place in anywhere you want on your computer. Unity should now build the project into an *XCode* project and open it.
1. Go to the newly opened *XCode* window
1. Select your phone as the device to install to in the upper left corner. It should say "Unity-iPhone > *name of your device*". If it says a "generic device", click it and find your phone in the list.
1. Select the small folder icon in the top left corner in the left panel and click on *Unity-iPhone* (it's the first item in the list) to open the project settings.
1. Select *Signing & Capabilites* tab in the center panel
1. Check *Automatically manage signing*
1. Log in with your Apple account by clicking *Add account..* if not already
1. Add something random to the end of *Bundle Identifier* to make it unique, can be anything
1. Change the *Team* to *your name (Personal Team)*
1. Click the *Play* icon in the top left corner
1. You will get an error that the app could not be launched. Trust your developer certificate on your phone by going to *Settings -> General -> Profiles and Device Management* and selecting the certificate with your name and clicking *Trust*
1. Click the *Play* icon again

# Ideas for expanding the game
- add more obstacles (browse the *Unity Asset Store* to find many free models)
- change colors of objects
- change materials
- add sounds (requires some coding)
- display a congratulations when you win (requires some coding)
- add shadows from objects on the ground (advanced, no coding required but needs a special shader that you can find online, search for `shadow matte`)
