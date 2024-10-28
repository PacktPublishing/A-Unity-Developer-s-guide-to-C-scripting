// PreferencesManager.cs
using UnityEngine;

[System.Serializable]
public class PlayerPreferences
{
    public float audioVolume;
    public int brightness;
    public bool subtitlesEnabled;
}

public class PreferencesManager : MonoBehaviour
{
    void Start()
    {
        PlayerPreferences prefs = new PlayerPreferences()
        {
            audioVolume = 0.8f,
            brightness = 50,
            subtitlesEnabled = true
        };

        // Serialize the PlayerPreferences object to a JSON string
        string prefsJson = JsonUtility.ToJson(prefs);
        Debug.Log("Serialized JSON: " + prefsJson);

        // Deserialize the JSON string back to a new PlayerPreferences object
        PlayerPreferences loadedPrefs = JsonUtility.FromJson<PlayerPreferences>(prefsJson);
        Debug.Log("Loaded Preferences: " + "Audio Volume - " + loadedPrefs.audioVolume + 
                  ", Brightness - " + loadedPrefs.brightness + 
                  ", Subtitles Enabled - " + loadedPrefs.subtitlesEnabled);
    }
}