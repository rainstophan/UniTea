
This will prevent the object from being destroyed when a new scene is loaded. You can also pass a reference to any other object to the DontDestroyOnLoad method, such as a GameObject or a Component.

Keep in mind that the Don't Destroy On Load function will not work on objects that are already in the scene when the game starts. It can only be used on objects that are created at runtime.

void Awake()
{
    DontDestroyOnLoad(gameObject);
}

This can be useful if you want to keep certain objects around between scenes, such as a music player or a save game manager.
