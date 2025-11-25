# Pi-Rush
### Reach for the digits — one jump at a time!

Pi Rush is a fast-paced, addictive memory and timing game where you sling your character from circle to circle, hitting the correct next digit of Pi. One mistake and you fall back to start!
Your goal : climb as high as possible, improve your memory, and beat your personal or friends’ high scores. Quick thinking, precision, and focus turn memorizing numbers into a thrilling arcade challenge.

## 👥 Team Members
- Yanai Levy
- Raphael Coeffic

## 📜 Project Files

 - [Formal Elements Document](formal-elements.md)

## Core Loop

Play the game on itch.io: [Link of the game](https://genesiswarfare.itch.io/pi-rush-core)

### How to play:

Please play in Fullscreen with the FullScreen button (it's for mobile 1920*1080).

Drag and release to sling your character. Land on the correct next digit of Pi to climb higher. Two circles appear each turn, one is correct, one is wrong. If you hit the correct circle, your character moves up and the next digits appear. If you hit the wrong circle, you go back to the last safe point and two new circles spawn. If you miss completely and fall off-screen, you return to the last safe point but the circles stay the same. At the end of the level, we show the highest Pi digit you reached, along with a button to restart the game.


### UML
```plaintext
Assets
├── Prefabs
│   └── CircleDigit.prefab
│
├── Scenes
|   ├── LevelFinished.unity
│   └── SampleScene.unity
│
├── Scripts
│   ├── Enemies
│   │   └── CircleDigit.cs
│   │
│   ├── Gameplay
│   │   ├── CleanTrayZone.cs
│   │   ├── DrinkPickupZone.cs
│   │   ├── FoodPickupZone.cs
│   │   ├── GuestOrder.cs
│   │   ├── TableInteraction.cs
│   │   └── TableOrder.cs
│   │
│   ├── Managers
│   │   ├── GameManager.cs
│   │   └── SpawnManager.cs
│   │
│   ├── Player
│   │   └── PlayerController.cs
│   │
│   ├── UI
│   │   └── EndScreen.cs
│   │
│   └── Utils
│       ├── CameraFollow.cs
│       └── PiDigits.cs
│       ...............
├── ProjectSettings
└── Packages

```
<img width="372" height="497" alt="image" src="https://github.com/user-attachments/assets/bc4fa349-6460-4164-bd86-78c73447b813" />


