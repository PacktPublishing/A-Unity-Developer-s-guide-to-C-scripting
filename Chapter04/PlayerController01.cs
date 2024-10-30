// PlayerController01.cs

using UnityEngine;
 
public class PlayerController01 : MonoBehaviour
{ 
    public float speed = 5.0f;
      
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f,
            0.0f);
        transform.position += speed * Time.deltaTime * movement;
    }
}