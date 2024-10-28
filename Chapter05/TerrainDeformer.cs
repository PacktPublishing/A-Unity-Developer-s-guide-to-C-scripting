// TerrainDeformer.cs
using UnityEngine;

public class TerrainDeformer : MonoBehaviour
{
    public Terrain terrain;
    private TerrainData terrainData;
    private float[,] originalHeightMap;

void Start()
    {
        terrainData = terrain.terrainData;

        originalHeightMap = terrainData.GetHeights(0, 0, 
           terrainData.heightmapResolution, 
           terrainData.heightmapResolution);
    }

void Update()
    {
        Vector3 playerPosition = transform.position;
        Vector3Int terrainPosition = new Vector3Int(
            Mathf.RoundToInt(playerPosition.x),
            Mathf.RoundToInt(playerPosition.y),
            Mathf.RoundToInt(playerPosition.z)
        );

        // Deform terrain under player
        // Note: This is a simplified example. In practice, 
        // you’ll need to convert the player's position to 
        // terrain’s local space and modify a range of 
        // heights around the player.
        terrainData.SetHeights(terrainPosition.x, 
            terrainPosition.z, 
            new float[,] { { 0.5f } });
    }
 
void OnDestroy()
    {
        // Restore the original terrain heights when the
        // script is destroyed
        terrainData.SetHeights(0, 0, originalHeightMap);
    }
}