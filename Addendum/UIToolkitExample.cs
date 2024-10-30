using UnityEngine.UIElements;

public class UIToolkitExample : MonoBehaviour
{
	private void OnEnable()
	{
	// Get the root visual element from the current UI document var root = GetComponent<UIDocument>().rootVisualElement;
	
	// Create a new button
	Button myButton = new Button(); myButton.text = "Click Me!";
	
	// Register a click event
	myButton.clicked += () => Debug.Log("Button Clicked!");

	// Add the button to the root element root.Add(myButton);
	}
}