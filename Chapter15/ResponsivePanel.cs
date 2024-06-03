// ResponsivePanel.cs
using UnityEngine;
using UnityEngine.UI;

public class ResponsivePanel : MonoBehaviour
{
    public RectTransform panel;

    void Update()
    {
        if (Screen.width > Screen.height) // Landscape mode
        {
            panel.anchorMin = new Vector2(0.25f, 0.25f);
            panel.anchorMax = new Vector2(0.75f, 0.75f);
        }
        else // Portrait mode
        {
            panel.anchorMin = new Vector2(0.1f, 0.1f);
            panel.anchorMax = new Vector2(0.9f, 0.9f);
        }
    }
}