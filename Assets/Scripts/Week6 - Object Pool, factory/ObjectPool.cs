using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public List<GameObject> bullets; // Create list for bullet game objects
    public int numBullets = 10; // Number of bullet game object in list

    private void Awake()
    {
        bullets = new List<GameObject>(); // Declare new list
        for (int i = 0; i < numBullets; i++) // For loop to instantiate number of game objects equal to numBullets
        {
            GameObject obj = new GameObject("Bullet " + i); // Instantiate bullets
            obj.SetActive(false); // Set bullets to inactive
            bullets.Add(obj); // Add inactive bullets to list
        }
    }
}
