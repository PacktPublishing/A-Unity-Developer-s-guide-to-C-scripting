// GameController.cs
using UnityEngine;
	
public class GameController : MonoBehaviour
{
    void Start()
    { 
        // Broadcast message to all components in the GameController 
        // object and its children
        gameObject.BroadcastMessage("Initialize", 
            SendMessageOptions.RequireReceiver);
    }
}