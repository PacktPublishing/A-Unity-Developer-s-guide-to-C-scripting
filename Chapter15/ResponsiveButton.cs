// ResponsiveButton.cs
using UnityEngine;
using UnityEngine.UI;

public class ResponsiveButton : MonoBehaviour
{
    public CanvasScaler canvasScaler;
    public Button myButton;

    void Start()
    {
        // Configure the Canvas Scaler for resolution independence
        canvasScaler.uiScaleMode = 
            CanvasScaler.ScaleMode.ScaleWithScreenSize;
        canvasScaler.referenceResolution = new Vector2(1920, 1080);

        // Set up the button's Rect Transform to anchor to the bottom-
        right corner
        RectTransform buttonRectTransform = 
            myButton.GetComponent<RectTransform>();
        buttonRectTransform.anchorMin = new Vector2(1, 0);
        buttonRectTransform.anchorMax = new Vector2(1, 0);
        buttonRectTransform.pivot = new Vector2(1, 0);
        buttonRectTransform.anchoredPosition = new Vector2(-50, 50);

        // Add an onClick listener to provide haptic feedback
        myButton.onClick.AddListener(TriggerHapticFeedback);
    }

    void TriggerHapticFeedback()
    {
        if (SystemInfo.supportsVibration)
        {
            Handheld.Vibrate();
        }
    }
}