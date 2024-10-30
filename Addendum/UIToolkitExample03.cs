using UnityEngine;
using UnityEngine.UIElements;

public class UIToolkitExample03 : MonoBehaviour
{
	private void OnEnable()
	{
		var root = GetComponent<UIDocument>().rootVisualElement;
		
		// Create a button
		Button myButton = new Button(); myButton.text = "Click Me!";
		
		// Register a click event handler
		myButton.clicked += () => Debug.Log("Button clicked!");
		
		// Add the button to the root element root.Add(myButton);
		root.Add(myButton);
	}
}