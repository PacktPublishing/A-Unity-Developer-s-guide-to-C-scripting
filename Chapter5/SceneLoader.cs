// SceneLoader.cs
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadGameLevel()
    {
        SceneManager.LoadScene("GameLevel");
    }
}