// UIManager.cs
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public CanvasScaler canvasScaler;

    void Start()
    {
        // Set the reference resolution to ensure consistent UI 
        scaling
        canvasScaler.referenceResolution = new Vector2(1920, 1080);
        canvasScaler.uiScaleMode = 
            CanvasScaler.ScaleMode.ScaleWithScreenSize;
    }
}