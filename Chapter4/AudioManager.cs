// AudioManager.cs
using UnityEngine;
	
public class AudioManager : MonoBehaviour
{
    // Singleton instance
    private static AudioManager _instance;

    // Public accessor for the singleton instance
    public static AudioManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = 
                    FindObjectOfType<AudioManager>();
                if (_instance == null)
                {
                    GameObject singletonObject = 
                        new GameObject(typeof(AudioManager).Name);
                    _instance =
                        singletonObject.AddComponent<AudioManager>();
                }
            }
            return _instance;
        }
    }

    // Private constructor to prevent external 
    // instantiation
    private AudioManager() { }


    // Example method
    public void PlaySound(AudioClip clip)
    {
        // Play sound logic
    }
}