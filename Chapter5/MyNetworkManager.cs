// MyNetworkManager.cs
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager
{
    public override void   
        OnServerAddPlayer(NetworkConnection conn,
            short playerControllerId)
    {
        GameObject player = Instantiate(playerPrefab,   
            Vector3.zero, 
            Quaternion.identity);
        NetworkServer.AddPlayerForConnection(conn, player, 
            playerControllerId);
    }
}