
// The observer pattern is a design pattern that is used to define a one-to-many dependency between objects, such that when one object changes state, all of its dependents are notified and updated automatically. It allows objects to communicate and stay in sync with each other without tight coupling.
public class WaveData : MonoBehaviour
{
    private List<IObserver> observers = new List<IObserver>();
    private int waveNumber;
    private int lives;

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.OnNotify();
        }
    }

    public int WaveNumber
    {
        get { return waveNumber; }
        set
        {
            waveNumber = value;
            NotifyObservers();
        }
    }

    public int Lives
    {
        get { return lives; }
        set
        {
            lives = value;
            NotifyObservers();
        }
    }
}
public interface IObserver
{
    void OnNotify();
}

public class WaveNumberText : IObserver
{
    private WaveData waveData;
    private Text text;

    public WaveNumberText(WaveData waveData, Text text)
    {
        this.waveData = waveData;
        this.text = text;
    }

    public void OnNotify()
    {
        text.text = "Wave: " + waveData.WaveNumber;
    }
}

public class LivesText : IObserver
{
    private WaveData waveData;
    private Text text;

    public LivesText(WaveData waveData, Text text)
    {
        this.waveData = waveData;
        this.text = text;
    }

    public void OnNotify()
    {
        text.text = "Lives: " + waveData.Lives;
    }
}

// To use this system in your game, you can create instances of the WaveData class and the UI element classes and register the UI element instances as observers of the WaveData instance. For example:
WaveData waveData = new WaveData();

Text waveNumberText = GameObject.Find("WaveNumberText").GetComponent<Text>();
IObserver waveNumberObserver = new WaveNumberText(waveData, waveNumberText);
waveData.AddObserver(waveNumberObserver);

Text livesText = GameObject.Find("LivesText").GetComponent<Text>();
IObserver livesObserver = new LivesText(waveData, livesText);
waveData.AddObserver(livesObserver);

// whenever you update the wave number or remaining lives in the WaveData instance, the UI elements will be automatically updated to reflect the new values. 
waveData.WaveNumber = 5;
waveData.Lives = 3;
