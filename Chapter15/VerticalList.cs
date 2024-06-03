// VerticalList.cs
using UnityEngine;
using UnityEngine.UI;

public class VerticalList : MonoBehaviour
{
    public GameObject buttonPrefab;
    public Transform contentParent;

    void Start()
    {
        // Instantiate multiple buttons and add them to the Vertical 
        Layout Group
        for (int i = 0; i < 10; i++)
        {
            GameObject button = Instantiate(buttonPrefab, 
                contentParent);
            button.GetComponentInChildren<Text>().text = "Button " + 
                                                         (i + 1);
        }
    }
}