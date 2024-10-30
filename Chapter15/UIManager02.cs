// UIManager02.cs
using UnityEngine;
using UnityEngine.UI;

public class UIManager02 : MonoBehaviour
{
    public CanvasScaler canvasScaler;

    void Start()
    {
        // Set the reference resolution to ensure consistent UI scaling
        canvasScaler.referenceResolution = new Vector2(1920, 1080);
        canvasScaler.uiScaleMode = 
            CanvasScaler.ScaleMode.ScaleWithScreenSize;
    }
}