// ExampleScript.cs
using UnityEngine;
	
public class ExampleScript : MonoBehaviour
{
    void Start()
    {
        // Accessing the AudioManager Singleton instance
        AudioManager audioManager = AudioManager.Instance;

        // Example usage: play a sound
        AudioClip soundClip = 
            Resources.Load<AudioClip>("ExampleSound");
        if (soundClip != null)
        {
            audioManager.PlaySound(soundClip);
        }
        else
        {
            Debug.Log("Sound clip not found!");
        }
    }
}

//Note: The text in the book has an extra bracket because it was shown as
//      part of a large file with multiple classes.