# Virtual Showroom

An immersive virtual car showroom experience center built with Unity. Walk through a fully designed showroom space, explore vehicles in a realistic 3D environment, and interact with the exhibit — all from a first-person perspective.

> **Status:** Early Development

---

## Features

- **First-Person Walkthrough** — navigate the showroom freely using keyboard and mouse controls
- **3D Showroom Environment** — a purpose-built showroom space with embedded textures and materials
- **Custom Materials** — transparent glass, reflective floors, ambient lighting, and a city skybox backdrop
- **Universal Render Pipeline** — modern rendering with URP for high visual quality and performance
- **Cinemachine Integration** — smooth camera handling for polished player movement
- **New Input System** — responsive controls via Unity's Input System package

## Tech Stack

| Component | Details |
|---|---|
| **Engine** | Unity 6000.3.12f1 (Unity 6) |
| **Render Pipeline** | Universal Render Pipeline (URP) 17.3.0 |
| **Language** | C# |
| **Camera** | Cinemachine 2.10.7 |
| **Input** | Unity Input System 1.19.0 |
| **Shader Authoring** | Shader Graph 17.3.0 |
| **License** | MIT |

## Project Structure

```
Assets/
├── MeshCraft/                    # Core showroom assets
│   ├── 3dModel/ShowRoom/         # Main showroom FBX model with embedded textures
│   ├── Materials/                # Floor, glass, lighting, and skybox materials
│   ├── Skybox Texture/           # City panorama skybox
│   └── Updated3dModel/           # Revised model iterations
├── StarterAssets/                # Player controller package
│   ├── FirstPersonController/    # FPS movement scripts and prefabs
│   ├── InputSystem/              # Input action maps
│   └── Environment/              # Ground plane and environment helpers
├── Scenes/
│   └── SampleScene.unity         # Main showroom scene
├── Settings/                     # URP renderer and pipeline assets
└── Resources/                    # Runtime-loaded resources
```

## Getting Started

### Prerequisites

- **Unity 6** (version `6000.3.12f1` or compatible)
- **Git LFS** recommended for large FBX/texture files

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/MeshCraftAssets/Virtual-Showroom.git
   ```

2. **Open in Unity Hub**
   - Launch Unity Hub
   - Click **Open** → navigate to the cloned folder
   - Unity will import assets and resolve packages automatically

3. **Open the scene**
   - In the Project window, navigate to `Assets/Scenes/`
   - Double-click `SampleScene.unity`

4. **Play**
   - Press the **Play** button in the Unity Editor
   - Use `WASD` to move, mouse to look around

### Controls

| Input | Action |
|---|---|
| `W` `A` `S` `D` | Move forward / left / back / right |
| `Mouse` | Look around |
| `Space` | Jump |
| `Left Shift` | Sprint |

## Roadmap

- [ ] Car models with interactive hotspots
- [ ] UI panels for vehicle specs and pricing
- [ ] Color/variant switcher for exhibited cars
- [ ] Lighting presets (day / night / showroom spotlight)
- [ ] WebGL build for browser-based access
- [ ] Multiplayer showroom visits
- [ ] VR support

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/car-configurator`)
3. Commit your changes
4. Push to the branch and open a Pull Request

## License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

---

Built by [MeshCraft Assets](https://github.com/MeshCraftAssets)
