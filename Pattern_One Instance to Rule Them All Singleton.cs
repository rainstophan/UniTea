public class Singleton : MonoBehaviour
{
    public static Singleton Instance { get; private set; }
    public AudioManager AudioManager { get; private set; }
    public UIManager UIManager { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        AudioManager = GetComponentInChildren<AudioManager>();
        UIManager = GetComponentInChildren<UIManager>();
    }
}


//*******************************

Singleton.Instance.AudioManager.PlaySound();


//*******************************
//Think of a Singleton as an improved global variable due to the fact that you cannot create more than one. 
