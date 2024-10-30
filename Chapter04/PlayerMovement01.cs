// PlayerMovement01.cs

using UnityEngine;
 
public class PlayerMovement01 : MonoBehaviour
{ 
    public float speed = 5.0f;
      
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * 
                           speed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * speed *
                         Time.deltaTime;

        transform.Translate(horizontal, 0f, vertical);
    }
}