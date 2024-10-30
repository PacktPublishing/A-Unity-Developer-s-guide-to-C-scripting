// PlayerMovement01.cs
using UnityEngine; 
// using Unity.Netcode;  Must install Unity.Netcode package first

public class PlayerMovement02 : MonoBehaviour 
    //NetworkBehaviour is expected when using Unity.Netcode
{
    public float speed = 10f;
    bool isLocalPlayer = false; 
       // Remove parameter isLocalPlayer after installing Unity.Netcode

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