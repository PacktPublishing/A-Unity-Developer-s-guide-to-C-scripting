// PlayerController03.cs (version 2)
using UnityEngine;

public class PlayerController02 : MonoBehaviour
{
    void Update()
    {      // Left Arrow moves Player to the left
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0);
        }   // Right Arrow moves Player to the right
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);
        }
    }
}