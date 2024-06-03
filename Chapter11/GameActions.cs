// GameActions.cs
using MLAPI;
using MLAPI.Messaging;

public class GameActions : NetworkBehaviour {
    [ServerRpc]
    public void FireProjectileServerRpc() {
        PerformFire();
        FireProjectileClientRpc();
    }

    [ClientRpc]
    private void FireProjectileClientRpc() {
        // This method would be called on all clients
        PerformFire();
    }

    void PerformFire() {
        // Code to instantiate and fire a projectile
    }
}