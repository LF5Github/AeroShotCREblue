AeroShotCRE is a fork of AeroShot aiming to add features useful to creators of Windows Crazy Error videos and fix certain bugs from the original software. This program saves 7 screenshots with the following file name suffixes:
* b1 - Optimized for dark/black backgrounds, active titlebar
* b2 - Optimized for dark/black backgrounds, inactive titlebar
* w1 - Optimized for light/white backgrounds, active titlebar
* w2 - Optimized for light/white backgrounds, inactive titlebar
* t1 - Fully transparent title bar, active
* t2 - Fully transparent title bar, inactive
* mask - A black mask showing the shape of the window without shadows

## Changelog
### 1.9.7
* Fixed some DPI issues
* A new Titlebar design

### 1.9.6.1
* Added a feature that allows you to start AeroShotCRE blue on startup
* Some text are hidden to have more simplicity

### 1.9.6
* Everything has a newer look!
* 10% smaller!
* An exit button to fully exit AeroShotCRE blue!
* Moved the "save screenshots to disk or clipboard" to the "Save to..." tab

### 1.9.5
* [Microsoft Store only release](https://www.microsoft.com/store/productId/9NNBCDGN1ZS8)
* Fixed the Browse button in .NET 4.6 builds

### 1.9.4
* [Microsoft Store only release](https://www.microsoft.com/store/productId/9NNBCDGN1ZS8)
* Attempted to make capture of admin windows more reliable when the program itself is not running as admin

### 1.9.3
* Added "Keep window centered" crop mode (useful on Windows 11)
* Fixed fonts in the main settings UI
* Custom keyboard shortcut support
* Removed the dedicated Windows Vista Optimizations mode
  * Optimizations are now applied per-OS as needed

### 1.9.2
* Added support for copying transparent screenshots into the clipboard
  * Broken on Windows 11 for now
* Added a warning if the application is already running
* Reverted to the old backdrop creating mechanism and added a delay between capturing screenshots
  * This is still an attempt to fix the bug where background removal fails because the screenshot is taken too early
  * Capture is slower as a result but less prone to failure (hopefully)

### 1.9.1
* Reworked how the backdrop is being created
  * Fixes most of the cases where background removal failed
* Fixed an oversight that made the crop based on the inactive screenshot capture 
  * This also addresses screenshots not being saved if inactive dark optimized screenshot was disabled
* More sensible defaults based on OS detection
  * Inactive light optimized is only enabled on operating systems with Afterglow by default (Windows 7 build 6730 - Windows 8 build 8432) or if [Aero Glass for Win8+](https://www.glass8.eu/) is running
  * Mask and fully transparent screenshot capture is only enabled if an operating system with Aero Glass support is detected (Windows Vista [any supported build] - Windows 8 build 8432)
* Added support for fully transparent screenshots on Windows Vista
* New icon by @RUvlad1

### 1.9.0
* Reworked inactive window capture (way more reliable)
* Fixed Out of memory errors
* Fixed a bug that caused the background removal to fail (only a 300x300px rectangle in the top left corner would have the background removed)
* Removed the "Press OK to start the program" dialog
* Fixed a typo in the startup notification
* Added a warning message if background removal fails
* Improved support for DPI scaling on Windows 10 1607 and above (no more cropped out shadows if the scaling factor is too high)

### 1.8.3
* Vista Optimizations no longer have to restart DWM

### 1.8.2
* Added a special colorization mode for Windows Vista
  * Fixes masks on Vista
* Condensed the settings window, fixed TabIndexes
* Fixed certain crashes on Windows XP

### 1.8.1
* Performance improvements (Disabled calculating white optimized screenshot if it's disabled)
* Fix for out of memory errors on Windows XP when a window dimension is an even number
* Fixed a "bug" that made a small rectangle appear in inactive window screenshot if the window was positioned in the upper left corner of the screen while capturing the image
* Deleted all traces of opaque screenshots feature which was disabled since v1.6.0
  * The setting dialog is smaller as a result and fits on a 720p screen now

### 1.8.0
* Added support for fully transparent screenshots (t1, t2)
* Added Custom canvas size

### 1.7.0
* Windows XP and Vista Beta support (only certain builds of Vista, requires testing)
* Added support for capturing the window mask
* More verbose error messages for debugging
* Added option to disable any screenshot type in the settings

### 1.6.1
* Addresses an issue where screenshots optimized for white backgrounds saved in place screenshots optimized for dark backgrounds in certain conditions

### 1.6.0
* Automatic inactive screenshot capture
* Enabled the algorithm for white backgrounds for better colored title bars
* Temporarily disabled checkerboard and solid backgrounds

# AeroShot
AeroShot is a free (GPLv3) and open source screenshot utility designed for capturing individual windows. It captures screenshots **with full transparency**, such as seen in the Windows Aero visual style. This allows for a clean and professional screenshot, useful for showcasing an application. The entire program is written in C#, heavily utilizing the Windows API.

AeroShot was originally developed by Caleb Joseph in 2011, and was inspired by the proprietary [Window Clippings](http://www.windowclippings.com/) program.

Please leave any feature suggestions or bug reports in the issue tracker.

## AeroShot Mini
AeroShot is dead, long live **AeroShot Mini**!

AeroShot Mini is the next generation of the original AeroShot, and is based on its Free Software code base. AeroShot Mini runs from the system tray, and doesn't have a main window GUI. A settings window is still available if need.

If you want the original AeroShot experience with the newer features, *AeroShot Classic* is available, but it doesn't have all the features of *AeroShot Mini*, and no features will be added.

## Usage
Press **Alt + Print Screen** on the desired window to be captured, while AeroShot is running in the background.

This save a transparent or opaque PNG image into the chosen folder with a file name corresponding to the title of the captured window, or to the clipboard if selected. Please be aware that very few applications support pasting transparent images from the clipboard, and that they will most likely not be correctly pasted.

## Change Log

### 1.5.0
20th July 2015
##### Both AeroShot Mini & AeroShot Classic
* Fix for HiDPI displays
* No longer allows you to try to disable ClearType if it's already turned off on your system.

##### AeroShot Mini
* Added option to change the color of Aero Glass. For obvious reasons, it only works in Windows 7 & Vista.

**Note:** Custom Aero Glass colors was not added to *Classic*, as it's dead now and this is the release.

### 1.4.0
11th May 2015
##### Both AeroShot Mini & AeroShot Classic
* New program icon. Based on icons by [Yusuke Kamiyamane](http://p.yusukekamiyamane.com/).
* Small adjustments to the GUI style.
* Added option to delay the capturing of screenshots when using the hotkey (1-10 seconds).
* Added option to temporarily disable ClearType on the target window while the screenshot is being captured.

##### AeroShot Mini
* First Release. Runs from system tray icon; screenshot capture via hotkey only.

##### AeroShot Classic
* Use a native control for the 'Capture Screenshot' button.

## Change Log from the original AeroShot

### 1.3.2
23rd October 2012

* Fixed AeroShot not working correctly on Windows XP.
* Improved the list of open windows in the user interface, it should now show all windows open on the taskbar.

### 1.3.1
28th March 2012

* **New capture hotkey**: AeroShot now uses Alt + Print Screen to capture, this resolves conflicts with Windows 8.
* AeroShot's interface now uses Segoe UI, previously Microsoft Sans Serif was used.

### 1.3
31st December 2011

* **Capture to Clipboard**: Screenshots may now be copied to the clipboard instead of being saved to the disk.
* **Show Mouse Pointer**: The mouse pointer may now be visible in screenshots when using Windows Key + Print Screen.

**Changes**:
* Improved how windows are focused on capture.
* Improved how the taskbar is hidden and restored on capture.
* "Take Screenshot" button replaced with a custom button.

### 1.2.1
8th November 2011

**Changes**:
* Slightly faster image processing

### 1.2
10th August 2011

**Changes**:
* Taskbar is hidden during capture, this fixes issues when taking screenshots of maximized windows.
* Increased the margin of the capture area from 40 pixels to 100 pixels. This improves capturing of custom themes with large window drop shadows.

### 1.1
13th June 2011

* **Image Cropping**: Transparent areas of screenshots are now automatically cropped out.
* **Window Resizing**: You may now specify a resolution you wish your screenshot to be captured in. The selected window will be automatically resized to fit the resolution chosen. This is useful for web design where you need screenshots to be of an exact size.
* **Opaque Backgrounds**: Lets you save screenshots with a solid background, rather than a transparent one.
* **Interface Improvements**: The main GUI has been cleaned up.
* **Improved Capturing**: Screenshots are now taken much more faster and reliably.
* **Windows XP support**: AeroShot will now function flawlessly on Windows XP.

### 1.0
5th June 2011

* **Initial release**
