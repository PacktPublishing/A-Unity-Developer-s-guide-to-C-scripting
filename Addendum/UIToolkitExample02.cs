using UnityEngine.UIElements;

public class UIToolkitExample02 : MonoBehaviour
{
    private void OnEnable()
    {
    // Get the root visual element from the current UI document
    var root = GetComponent<UIDocument>().rootVisualElement;

    // Create a new Button
    Button myButton = new Button(); myButton.text = "Click Me!";
    // Add the button to the root element
    root.Add(myButton);
    }
}