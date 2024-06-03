// CenteredUI.cs
using UnityEngine;
using UnityEngine.UI;

public class CenteredUI : MonoBehaviour
{
    public RectTransform uiElement;

    void Start()
    {
        // Set the anchor points to the center
        uiElement.anchorMin = new Vector2(0.5f, 0.5f);
        uiElement.anchorMax = new Vector2(0.5f, 0.5f);
        uiElement.pivot = new Vector2(0.5f, 0.5f);
        uiElement.anchoredPosition = Vector2.zero;
    }
}