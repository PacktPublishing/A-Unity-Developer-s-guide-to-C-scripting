// PlayerMovement01.cs
using UnityEngine;

public class PlayerMovement03 : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") *
                      moveSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") *
                      moveSpeed * Time.deltaTime;

        transform.Translate(moveX, 0f, moveZ);
    }
}