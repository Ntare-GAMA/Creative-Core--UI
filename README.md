
Creative Core UI

Overview
--------
Creative Core UI is a Unity project that contains UI assets, example scenes, and render-pipeline samples used for UI/UX prototypes and demos.

Quick facts
-----------
- Project product name: CreativeCore_UI_U6
- Recommended Unity Editor: 6000.4.5f1 (see ProjectSettings/ProjectVersion.txt)
- Notable packages: High Definition RP (HDRP) 17.4.0, Universal RP (URP) 17.4.0 (see Packages/manifest.json)

Contents of this repository
---------------------------
- `Assets/CreativeCore_UI/` — core UI assets, prefabs, materials, models and scripts.
- `Assets/CreativeCore_UI/Scenes/` — example scenes included with the package:
	- `TutorialScene_UI_Outdoor.unity`
	- `FinalScene_UI_Outdoor.unity`
- `Assets/_Recovery/` — auto-saved recovery scenes.
- `Packages/manifest.json` — Unity package dependencies (HDRP, URP, XR, etc.).
- `ProjectSettings/ProjectVersion.txt` — Unity Editor version used to author the project.
- `Assets/OFL.txt` — SIL Open Font License included for bundled fonts.

How to open
-----------
1. Install Unity Editor matching `ProjectSettings/ProjectVersion.txt` (recommended: `6000.4.5f1`).
2. Open the project folder in Unity Hub or open the folder from Unity Editor.
3. Open a scene from `Assets/CreativeCore_UI/Scenes/`, for example `FinalScene_UI_Outdoor.unity` to preview the UI demo.

Notes
-----
- This project contains both HDRP and URP packages; choose the appropriate render pipeline in your Unity project settings if you switch pipelines or import assets into other projects.
- Fonts included under `Assets/OFL.txt` are licensed under the SIL Open Font License (OFL) 1.1. Review `Assets/OFL.txt` for full license text.
- There is no single repository-level LICENSE file detected. If you intend to publish or share this project, add a `LICENSE` at the repo root describing the intended license for the non-font assets.

Contributing
------------
- For local changes: open the project in Unity, edit scenes or assets, then commit changes with your Git workflow.
- If you want, I can add a `CONTRIBUTING.md` and a repository `LICENSE` file — tell me which license you'd like.

Contact / Credits
-----------------
This project appears to be a UI asset/demo bundle named Creative Core UI. Fonts bundled under `Assets/` retain their original copyright and license; see `Assets/OFL.txt`.

----
Updated to reflect repository contents (Unity version, packages, scenes, and bundled font license).

