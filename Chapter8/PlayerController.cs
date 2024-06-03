// PlayerController.cs
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Set the 'isJumping' parameter to true when the space bar is pressed
            animator.SetBool("isJumping", true);
        }
    }
}