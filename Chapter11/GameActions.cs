/*  Must install the Unity.Netcode package from the Package Manager.
using Unity.Netcode;

public class GameActions : NetworkBehaviour {
    [ServerRpc]
    public void FireProjectileServerRpc()
    {
        PerformFire();
        FireProjectileClientRpc();
    }

    [ClientRpc]
    private void FireProjectileClientRpc() {
        // This method will be called on all clients
        if (!IsServer) // Avoid double execution on the server  {
            PerformFire();
        }
    }

    void PerformFire(){
        // Code to instantiate and fire a projectile
    
} */ 

