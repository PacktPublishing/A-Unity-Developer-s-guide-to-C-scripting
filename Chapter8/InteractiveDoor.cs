// InteractiveDoor.cs
using UnityEngine;

public class InteractiveDoor : MonoBehaviour
{
    public Animator doorAnimator;
    public float interactionRange = 2f;

    private void Update()
    {
        // Check if the player is within the interaction range
        if (Vector3.Distance(transform.position, PlayerController.instance.transform.position) <= interactionRange)
        {
            // Play the "Open" animation
            doorAnimator.SetTrigger("Open");
        }
        else
        {
            // Play the "Close" animation
            doorAnimator.SetTrigger("Close");
        }
    }
}