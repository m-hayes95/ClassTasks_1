using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnerGizmos : MonoBehaviour
{
    public GameObject[] spawnPrefabArray; // Ref to prefab game object Array.
    public int numSpawns; // Ref to how many times the prefab will spawn, change value in inspector.

    // Delcare an int value to randomly select a prefab from the Array.
    public int randomIndex;
    public Vector3 center, size; // Center point and size of the Gizmo and spawn area.

    public void Start()
    {
        // Use a for loop to loop through numSpawns Value, calling the nested method each time.
        for (int i = 0; i < numSpawns; i++)
        {
            SpawnRandomPrefab();
        }
    }

    public void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0.3f, 0f, 1f, 0.5f); // Set the Gizmos colour to a new colour (R,G,B,A).
        Gizmos.DrawCube(center, size); // Draw the gizmos as a cube using the center and size variables as parameters.
    }

    public void SpawnRandomPrefab()
    {
        // Assign a random value to the random index variable
        randomIndex = Random.Range(0, spawnPrefabArray.Length);
        // Declare a new vector 3 that has a random X and Z value and fixed Y axis. This is added to the center var value.
        Vector3 randomCubeSpawnLocationFromCenter = center + new Vector3(Random.Range(-10, 11), 15f, Random.Range(-10, 11));
        // Instantiate the prefabed game object using the new vector 3 random value as the location, with no rotation.
        Instantiate(spawnPrefabArray[randomIndex], randomCubeSpawnLocationFromCenter, Quaternion.identity);
    }

    
}
