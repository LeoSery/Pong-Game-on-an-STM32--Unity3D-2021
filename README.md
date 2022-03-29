# Pong-Game-on-an-STM32
Game made with @Tartoo during our bachelor year 2 (2021/2022) for an IOT course at Ynov.

## Summary
```
- ### I. Présentation
- ### II. Unity part 
    - A. How to open the project
    - B. How to build the project 
    - C. How to Play the project
    - D. Problems solving
- ### III. STM32 part 

    - A. Aaa
```
## I. Presentation

Project realized during an IOT course in second year at Ynov.

The project includes:
- The source code which is on the STM32 card which allows to recover the values of the joysticks.
- A mini Pong game made with unity3D compatible with joysticks.
- An explanation of how to mount on the STM32 card and how to configure the serial output to retrieve information from the joysticks


In our project a script allows unity to retrieve the hexadecimal values of our joysticks returned by the STM32.


## II. Unity part
### How to open the project:

- Clone the git repository to your computer with the following command :
```
git@github.com:LeoSery/Pong-Game-on-an-STM32.git
```

- open Unity Hub and do "*Add project from disk*"

    Select "`..\Pong-Game-on-an-STM32\PongGame`"

- Check that the project opens with the Unity editor in version "**2020.3.28f1**"

## How to build the project : 

- Once the project is open in Unity, do *"File" > "Build Settings"*

- In the window that has just appeared, in the *"Scenes In Build"* section, make sure that *"scenes/Game"* is checked.

- for the platform choose: *"PC, Mac & Linux Standalone"*

- then choose your platform in *"Target Platform"*

- and finally press *"Build And Run"*

## Problems solving :

The project uses different optional Unity packages. 
If you have an error concerning a package go to: ***"Window > Package Manager"*** and check that you have the following packages installed: 

```
- 2D Pixel Perfect (4.0.1)
- 2D SpriteShape (5.2.0)
- 2D Sprite (1.0.0)
- Text Mesh Pro (3.0.6)
- Unity UI (1.0.0)
```