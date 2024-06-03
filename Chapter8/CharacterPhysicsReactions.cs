// CharacterPhysicsReactions.cs
using UnityEngine;

public class CharacterPhysicsReactions : MonoBehaviour
{
    public Animator animator;
    public float stumbleForce = 5f;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision was with an obstacle
        if (collision.gameObject.tag == "Obstacle")
        {
            // Play the "stumble" animation
            animator.SetTrigger("Stumble");

            // Apply a force to the character to make them stumble
            GetComponent<Rigidbody>().AddForce(-collision.contacts[0].normal * stumbleForce, ForceMode.Impulse);
        }
    }
}