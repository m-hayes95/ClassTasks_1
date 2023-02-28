using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    // width, height, depth of terrain.
    public int width, height, depth;
    // Scale of terrain and offset x and y coords.
    [SerializeField] private float scale = 20f, offsetX, offsetY;

    public void Start()
    {
        // Generate random offset on start
        offsetX = Random.Range(0f, 9999f);
        offsetY = Random.Range(0f, 9999f);
    }

    public void Update()
    {
        Terrain terrain = GetComponent<Terrain>(); // Define the terrain.
        // Get ref to terrain data and set it as the result of the GenerateTerrain Method.
        terrain.terrainData = GenerateTerrain(terrain.terrainData);

        // Generate the terrain data.
        TerrainData GenerateTerrain(TerrainData terrainData)
        {
            // Set the heightmap resolution and size of the terrain data.
            terrainData.heightmapResolution = width + 1;
            terrainData.size = new Vector3(width, depth, height);

            // Generate the height of the terrain and set to the terrain data.
            terrainData.SetHeights(0, 0, GenerateHeights());

            return terrainData;
        }
        // Generate the heights of the terrain.
        float[,] GenerateHeights()
        {
            float[,] heights = new float[width, depth];

            // Loop through each x and y coordinate to generate the heights.
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < depth; y++)
                {
                    heights[x, y] = CalculateHeight(x, y);
                }
            }
            return heights;
        }
        // Calculate the height at the given x and y coordinate.
        float CalculateHeight(int x, int y)
        {
            // Calculate the x and y coordinate based on the given scale and offset.
            float xCoord = (float)x / width * scale + offsetX;
            float yCoord = (float)y / depth * scale + offsetX;
            // Generate the height of the map using the Perlin noise method and return it.
            return Mathf.PerlinNoise(xCoord, yCoord);
        }
    }
    

}
