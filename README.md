# ArcEngine-App
C# App Created to Work With Homebrew Engine, using Mono and the C#, C++ interlop

## Projects
- **ScriptCore**: This class library is Arc's C# classes. This is what the user can build apps using, and also contains interfaces to the engine
- **ExampleApp**: This class library is effectivly the game the player is making. These scripts can be loaded into the engine as a DLL, and the scripts run from there.
### Script Core Classes
- **Entity**: This is what the user inherits from to create a script component. This automatically gets the transform from the Entity the user gets from it and stores it. This is the main interface for the user to access components on the entity.
- **Maths**
  - **Vector3** : Simple Maths class to create an Arc Vector3. Used for transforms and things like that
  - **Matrix4**  : used to create model matrices and camera matrices for positioning on entities in game world
### Example App Scripts
- **Player Movement**: Simple script that will eventually control the movement of an entity inside the game 
