# GAME_MODE

This project is intended to bring a computer as close as possible to a console. 
I see the main advantages of consoles in the fact that you switch them on and wait until the picture appears on the TV. It also has a great interface. Steam has already given us something good with the Big Picture, but unfortunately the PC with Windows is somewhat limited in bringing everything together. Game_Mode will do that in the future.I have built in a time limit which, when it has expired, puts the display on the first or second monitor, then starts Big Picture, before minimising all windows. With this, you can start your PC, for example via WOL or HOMEASSISTANT, and wait until the PC adjusts itself.

![Beispielbild](https://github.com/toonymak1993/Game_Mode/blob/master/custom_wallpaper.png)

A wide range of settings is possible, such as setting the seconds, which monitor it should switch to, etc. Colours, backgrounds and text colours can also be set. 

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
![settings](https://github.com/toonymak1993/Game_Mode/blob/master/settings.png)

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
- Integration with Homeassistat to control entities or scenes
- Automatic recognition of which screen I am on in order to return to the monitor atomatically
- Possible controller support

These are all somewhat complicated goals, but if you would like to join us and support us, I would appreciate any assistance you can offer.
