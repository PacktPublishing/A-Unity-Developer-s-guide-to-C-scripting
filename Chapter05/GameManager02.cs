// GameManager01.cs
using UnityEngine;

public class GameManager02 : MonoBehaviour
{
    public static GameManager02 Instance;

    void Awake() 
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Your game state data and methods here
}