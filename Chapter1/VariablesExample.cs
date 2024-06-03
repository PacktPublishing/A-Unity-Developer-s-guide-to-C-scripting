// VariablesExample.cs

using UnityEngine;
public class VariablesExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Integer variable
        int playerScore = 100;

        // Float variable
        float playerSpeed = 5.5f;

        // Double variable
        double playerHealth = 99.50009;

        // Boolean variable
        bool isGameOver = false;

        // Character variable
        char grade = 'A';

        // String variable
        string playerName = "Hero";

        // Output the values using Debug.Log
        Debug.Log("Player Name: " + playerName);
        Debug.Log("Score: " + playerScore);
        Debug.Log("Speed: " + playerSpeed);
        Debug.Log("Health: " + playerHealth);
        Debug.Log("Game Over: " + isGameOver);
        Debug.Log("Grade: " + grade);
    }
}