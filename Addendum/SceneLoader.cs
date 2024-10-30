using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
	public void LoadNewScene(string sceneName)
	{
	// Asynchronously load the scene in the background
	SceneManager.LoadSceneAsync(sceneName);
	}
}