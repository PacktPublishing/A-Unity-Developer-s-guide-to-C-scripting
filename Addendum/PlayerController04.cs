using UnityEngine;

using UnityEngine.InputSystem;

public class PlayerController04 : MonoBehaviour
{
	private Vector2 moveInput;
	public float speed = 5f;
	private CharacterController controller;
	private void Start(){
		controller = GetComponent<CharacterController>();
	}

// Input System event handler for the Move action
	public void OnMove(InputAction.CallbackContext context) {
		moveInput = context.ReadValue<Vector2>();
	}
	private void Update() {
	// Convert the input vector into movement and apply it
		Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
		controller.Move(move * speed * Time.deltaTime);
	}
}