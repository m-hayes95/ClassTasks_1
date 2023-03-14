using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeGenerator : MonoBehaviour
{
    // ref to maze wall game object
    public GameObject wallPrefab;
    // ref to size of gird
    public int mazeSize = 15;

    private void Start()
    {
        // loop through the rows of maze using maze size field
        for (int i = 0; i < mazeSize; i++)
        {
            // loop through the columns of maze using maze size field
            for (int j = 0; j < mazeSize; j++) {
                // Instantiate a wall prefab at the current position,
                // then store the new wall into a new variable
                GameObject newWall = Instantiate(wallPrefab, new Vector3(i, 0, j), Quaternion.identity);
                // Set the MazeGenerator game object as the parent of the instantiated new walls
                newWall.transform.parent = transform;
            }
        }

        
    }
}
