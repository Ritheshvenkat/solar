# Solar System AR Prototype

A Unity project exploring a 3D solar-system scene with planet textures, orbital motion, and Vuforia-related augmented-reality assets.

> **Status:** Student prototype / work in progress. The repository contains Unity project files and scripts; test the scene in your Unity setup before describing the AR experience as fully functional.

## Built with

- **Unity:** 2022.3.62f3
- **C#:** simple orbit, rotation, and floating-animation behaviours
- **Vuforia Engine:** package dependency configured in `Packages/manifest.json`
- **Assets:** planet and Sun texture maps, Unity scenes, materials, and image-target textures

## Current project contents

- `Assets/Scenes/SolarSystem.unity` — solar-system scene
- `Assets/OrbitPlanet.cs` — moves a planet around a referenced Sun transform and rotates it on its axis
- `Assets/Rotate.cs` — continuously rotates an object
- `Assets/FloatAnimation1.cs` — adds a small vertical floating animation
- `Assets/2k_*.jpg` — texture maps for celestial bodies
- `Assets/Editor/Vuforia/ImageTargetTextures/Planets/` — image-target texture assets
- `Packages/manifest.json` — Unity package dependencies

## Open the project

1. Install **Unity 2022.3.62f3** using Unity Hub.
2. Clone or download this repository.
3. In Unity Hub, select **Add project from disk** and choose the project folder.
4. Open the project and let Unity import assets and resolve packages.
5. Open `Assets/Scenes/SolarSystem.unity` and press **Play** to inspect the scene.

For Vuforia/AR testing, configure the required Vuforia licence and target setup in your own development environment. Do not publish licence keys or credentials in this repository.

## Important setup note

The `OrbitPlanet` component exposes a public `sun` Transform. Assign the Sun object in the Inspector for each planet using that script; otherwise the script cannot calculate the orbit correctly. Check the Unity Console for missing references or package errors when opening the project.

## Planned improvements

- Add screenshots or a short demo video showing the current scene.
- Document the scene controls and how image targets are used.
- Verify AR tracking on a supported device and record the exact tested setup.
- Add clear setup and troubleshooting notes after testing on a clean Unity installation.

## Learning goals

This project provides practice with Unity scene organisation, C# behaviours, 3D materials, simple orbital calculations, and the configuration of AR-related assets.

---

This repository is a learning prototype and is not presented as a production application.