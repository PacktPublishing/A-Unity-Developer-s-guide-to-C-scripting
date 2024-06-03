// FrameRateCounter.cs
using UnityEngine;
using UnityEngine.UI;

public class FrameRateCounter : MonoBehaviour
{
    public Text frameRateText;
    private float deltaTime = 0.0f;

    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        float fps = 1.0f / deltaTime;
        frameRateText.text = Mathf.Ceil(fps).ToString() + " FPS";
    }
}
