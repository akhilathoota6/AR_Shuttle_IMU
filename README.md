# AR_Shuttle_IMU
# AR Shuttle IMU App

## 📱 Project Overview
This Unity-based AR mobile app allows users to detect flat surfaces in the real world using ARCore, and place a 3D Shuttle on the detected surface. Once placed, the shuttle responds to the device's tilt using IMU sensors for motion control.

Built as part of an assignment for AR development at Grand Valley State University.

---

## 🔧 Build Instructions

### Requirements:
- Unity 2021.3.45f1 (LTS)
- AR Foundation (v5.1.3+)
- ARCore XR Plugin
- Android Build Support (SDK, NDK, OpenJDK)
- GitHub Desktop

### Building Steps:
1. Clone this repo or download ZIP
2. Open the project in Unity Hub
3. Go to **File > Build Settings**
4. Switch platform to **Android**
5. Make sure your scene is checked under "Scenes In Build"
6. Set package name to `com.akhila.arshuttle`
7. Go to **Player Settings → Other Settings**:
   - Scripting Backend: IL2CPP
   - Target Architectures: ARM64
   - Remove Vulkan, use OpenGLES3 only
   - Min API Level: Android 7.0 (API 24)
8. Click **Build or Build and Run**
9. Save the APK file
10. Install it via USB or `adb install` command

---

## 🎮 Features
- AR Plane Detection
- Touch-based 3D Shuttle placement
- IMU (accelerometer) based shuttle control
- Camera permission via AndroidManifest.xml

---

## 🔍 Usage Instructions
- Move phone to detect surfaces
- Tap once to place the shuttle
- Tilt the phone to move it in AR space

---

## ⚠️ Known Issues
- Surface detection is sensitive to lighting
- Shuttle placement only works once (by design)

---

## 👩‍💻 Author
**Akhila Thoota**  
Graduate Student, GVSU  
GitHub: [@akhilathoota6](https://github.com/akhilathoota6)

---

## 📎 Repository Link
[https://github.com/akhilathoota6/AR_Shuttle_IMU](https://github.com/akhilathoota6/AR_Shuttle_IMU)
