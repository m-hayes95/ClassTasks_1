using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSystemScript : MonoBehaviour
{
    [SerializeField] private GameObject tilePrefab; // Ref to the tile game object.
    [SerializeField] private int numTilesX; // Numeber of tiles in the X dir.
    [SerializeField] private int numTilesY; // Number of tiles in the Y dir.
    [SerializeField] private float tileSize; // Size of each tile.
    [SerializeField] private float spacing; // Spacing between each line.

    private void Start()
    {
        GenerateGrid();
    }
    // Generate Grid of tiles 
    private void GenerateGrid()
    {
        for (int x = 0; x < numTilesX; x++) // Loop through each tile in the X and Y directions.
        {
            for (int y = 0; y < numTilesY; y++)
            {
                // Calulate the position of the tile based on current X and Y values, tile size and spacing.
                Vector3 position = new Vector3(x * (tileSize + spacing), 0f, y * (tileSize + spacing));

                // Instantiate a new tile prefab at the calculated position and rotation.
                GameObject tile = Instantiate(tilePrefab, position, Quaternion.identity);
            }
        }
    }
}
