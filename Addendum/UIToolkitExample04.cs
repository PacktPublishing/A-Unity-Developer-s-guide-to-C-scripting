using UnityEngine;
using UnityEngine.UIElements;

public class UIToolkitExample04 : MonoBehaviour
{
	private void OnEnable()
	{
	var root = GetComponent<UIDocument>().rootVisualElement;

	// Create a button and assign a class name for USS styling Button myButton = new Button();
	myButton.text = "Styled Button"; myButton.AddToClassList("myButton");

	// Add the button to the root element root.Add(myButton);
	root.Add(myButton);
	
	// Load the USS file
	var styleSheet = Resources.Load<StyleSheet>("buttonStyle"); root.styleSheets.Add(styleSheet);
	}
}