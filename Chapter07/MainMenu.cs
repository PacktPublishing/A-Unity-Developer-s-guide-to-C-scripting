// MainMenu.cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Load the game scene
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        // Exit the game
        Application.Quit();
    }
}