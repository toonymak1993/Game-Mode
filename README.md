# GAME_MODE

In simple terms, the "Game Mode" is a Software where your computer or monitor automatically adjusts when a controller is detected. 
This means that the displayed screen switches to the desired mode, and, if desired, it can even turn on your TV using Wake-on-LAN (WOL) and change the audio settings. 
Additionally, it launches your preferred application launcher in fullscreen mode. An example of this would be Steam Big Picture or Playnite, which are special user interfaces for gaming.


# UI
</p>
<div style="display: flex; justify-content: space-between;">
  <img src="https://github.com/toonymak1993/Game_Mode/blob/master/ui_first.png" alt="Bild 1" width="40%" />
  <img src="https://github.com/toonymak1993/Game-Mode/blob/master/settings_hassio.png" alt="Bild 2" width="30%" />
  <img src="https://github.com/toonymak1993/Game-Mode/blob/master/settings_main_ui.png" alt="Bild 3" width="30%" />
</div>


# Features
- Switch to the desired monitor
- Auto Controller detection - Switch back to the default setting with the controller
 ![settings](https://github.com/toonymak1993/Game-Mode/blob/master/ui_internal_settings.png)

- Initiating a script at the beginning and end of a Gamemode using Home Assistant.
- TV wake-up via WOL
- Choose audio, video, launcher yourself
- Many design settings so that the software adapts to you

## Contents

It's not a perfect release, but it's a start to make it possible for people who have a monitor and a TV connected to their PC to have a console-like experience.
Unfortunately, my experience is not such that I was able to pack everything in at the beginning as I would have liked. Later realeses will add more features here: Please have a look at the Future tab.


- [Installation](#installation)
- [Usage](#usage)
- [Example_pictures](#example_pictures)
- [Backround_data](#backround_data)
- [Future_plans](#future_plans)

## Installation
You can download Game Mode from Github via this link [Click here](https://github.com/toonymak1993/Game_Mode/releases/tag/steam)
and install it. 

## Usage
#Settings
![settings](https://github.com/toonymak1993/Game_Mode/blob/master/settings_gamemode.png)
- 1: 
Set Time for the Script
Here, you can use the slider to choose how much time you want to elapse after 
the controller is detected before the Game Mode is activated.

- 2: 
Here you have the option to choose between the internal or external monitor.
This means that as soon as game mode starts, your desired monitor is set up.
Here too, please set the monitor beforehand; the settings saved in Windows will be selected

- 3: WOL
Enter the game mode with which TV you want it to activate for you via WOL.
He treats this process directly as one of the first and activates it.
Of course, your TV must also offer this option.

- 4: Set Launcher
Here you have the option to either use the Steam Bigpicture mode, which I personally use because it has an integrated shop or
As an example, the software Playnite in the picture here. Important to understand gamemode does not set the software.
With Playnite, for example, you have to set the Planite setting so that it starts in full screen mode. 

- 5: Set Audio
Here you can look at all your detected audio devices and choose the one you want, it also switches over briefly to test it
you can confirm that you want to use it using the checkbox below.
The next time Gamemode Mode starts, this audio will be changed when changing.

- 6: Set Autostart
Autostart is checked during installation because it is an essential function of game mode.
Here you can also deactivate it manually if desired, which is not recommended.

  
The tool works like a script, as soon as the seconds that you can set with the slider at the top of Settingns have elapsed, the tool then switches to the set screen (Internal/External), proceeds in the same way as (Windows+P) and minimises all windows and then starts Steam in Big Picture mode. (Custom launchers will be supported later) Every single point can be set in the settings.
## Display Preset
It is important that you have already set these settings beforehand so that Windows knows which setting the screen has (resolution/HDR/HZ). These settings are saved by Windows in the registry and are taken into account when you change.

![settings](https://github.com/toonymak1993/Game_Mode/blob/master/colors.png)
Under Settings, you can currently adjust the colours as follows: 
- Text Color
- Button Color when going over it like in the Example pictures
- Progress bar colour.
- Custom Wallpaper. 

Please restart the App to make the changes effective.

#Feature

## Example_pictures
</p>
<div style="display: flex; justify-content: space-between;">
  <img src="https://github.com/toonymak1993/Game_Mode/blob/master/custom_wallpaper.png" alt="Bild 1" width="30%" />
  <img src="https://github.com/toonymak1993/Game_Mode/blob/master/custom_wallpaper2.png" alt="Bild 2" width="30%" />
  <img src="https://github.com/toonymak1993/Game_Mode/blob/master/startgui2.png" alt="Bild 3" width="30%" />
</div>


## Backround_data
To save the settings, the game_mode app dynamically uses the APPDATA folder and creates its default settings here the first time it is started: 
These look like this: 

- 30 seconds timer.
- Text Colour White.
- Default background.
- Autostart because a main function is activated.
  
## Future_plans
## DESIGN
- Scaling to resolutions like 4k,2k
- Wallpaper collection to choose from
- Further design options such as button sizes and position and backround colour
- Translate the app into various languages.
##  FUNCTION

These are all somewhat complicated goals, but if you would like to join us and support us, I would appreciate any assistance you can offer.
