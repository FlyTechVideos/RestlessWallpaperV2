# RestlessWallpaperV2

This is the RestlessWallpaperV2 project as seen in the YouTube video on the [FlyTech Videos YouTube channel](https://youtube.com/FlyTechVideos).

The "aim" of this project is to animate the wallpaper. In this project, we use [special code written by Gerald Degeneve](https://www.codeproject.com/articles/856020/draw-behind-desktop-icons-in-windows-plus) in order to render a media player _behind the desktop._ (Most specifically, `Win32Wrapper.cs` and parts of `Program.cs`.)

Configurable parameters:

- `Form1.Designer.cs`, Line 64: Set the video source for the media player. (Ignore the warnings that you should not edit this file - editing it through the Visual Studio interface **does not work as intended**)

**Please note:** This software has been created for **demo purposes** and **not for productive use**. As such, it is not polished, written nicely, configurable, or in any way convenient to use. Do what you want with it, at your own risk.

**Legal information:** This project is *not licensed* because it includes CPOL-licensed code. For the sake of offering this repository in its whole form, I have decided to _not_ remove that code (because I slightly modified it), but rather just not put a license on this repository. As for me, you can do whatever you want with the code in this repository as long as you stick to the CPOL for `Win32Wrapper.cs` and `Program.cs`. If, for whatever reason, you want to use any code of this project and have licence questions regarding this repository, feel free to drop me an email at the email on my profile.