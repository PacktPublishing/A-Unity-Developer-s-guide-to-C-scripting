// PlayerScore.cs

// Needs NetCode package installed
/*
using Unity.Netcode;
using UnityEngine;
   
   public class PlayerScore : NetworkBehaviour {
       public NetworkVariable<int> score = 
           new NetworkVariable<int>(0, NetworkVariableReadPermission.Everyone, 
               NetworkVariableWritePermission.Server);

       [ServerRpc] 
       public void AddScore(int points) {
           score.Value += points;
       }
   }
*/