// SettingsMenu.cs
using UnityEngine;
using UnityEngine.UI; // Include the UI namespace

public class SettingsMenu : MonoBehaviour
{
    public Slider volumeSlider; // Reference to the volume slider

    void Start()
    {
        // Initialize the slider's value to the current game volume
        volumeSlider.value = AudioListener.volume;
    }

    public void SetVolume(float volume)
    {
        // Adjust the game's volume based on the slider's value
        AudioListener.volume = volume;
    }
}