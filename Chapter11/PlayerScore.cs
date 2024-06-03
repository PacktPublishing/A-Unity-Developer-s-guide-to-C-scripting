// PlayerScore.cs
using MLAPI;
using MLAPI.NetworkVariable;
using UnityEngine;

public class PlayerScore : NetworkBehaviour {
    [SyncVar]
    public int score;

    public void AddScore(int points) {
        if (IsServer) {
            score += points;
        }
    }
}