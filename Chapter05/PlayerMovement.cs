// PlayerMovement.cs
using UnityEngine; 
using UnityEngine.Networking;

public class PlayerMovement : NetworkBehaviour
{
    public float speed = 10f;

    void Update()
    {
        if (!isLocalPlayer) return;

        float x = Input.GetAxis("Horizontal") * speed * 
                  Time.deltaTime;
        float z = Input.GetAxis("Vertical") * speed * 
                  Time.deltaTime;
        transform.Translate(x, 0, z);
    }
}