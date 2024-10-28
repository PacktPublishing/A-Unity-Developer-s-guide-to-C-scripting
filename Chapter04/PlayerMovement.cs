// PlayerMovement.cs

using UnityEngine;
 
public class PlayerMovement : MonoBehaviour
{ 
    public float speed = 5.0f;
      
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal") * 
                           speed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * speed *
                         Time.deltaTime;

        transform.Translate(horizontal, 0f, vertical);
    }
}