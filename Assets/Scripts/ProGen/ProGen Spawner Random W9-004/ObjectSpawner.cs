using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] spawnPrefabArray; //Ref to prefab game object Array.
    public int numSpawns; //Ref to how many times the prefab will spawn, change value in inspector.

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Using for loop to call the spawn method a set value of items
            for (int i = 0; i < numSpawns; i++)
            {
                SpawnRandomPrefab(); //Call the method to instatiate the prefab at a random location
            }
            
        }
    }

    private void SpawnRandomPrefab()
    {
        //Create a int value to randomly select a prefab from the Array.
        int randomIndex = Random.Range(0, spawnPrefabArray.Length);
        //Declare a new vector 3 that has a random X and Z value and fixed Y axis.
        Vector3 randomCubeSpawnLocation = new Vector3(Random.Range(-10, 11), 15, Random.Range(-10, 11));
        //Instantiate the prefabed game object using the new vector 3 random value as the location, with no rotation.
        Instantiate(spawnPrefabArray[randomIndex], randomCubeSpawnLocation, Quaternion.identity);
    }
}
