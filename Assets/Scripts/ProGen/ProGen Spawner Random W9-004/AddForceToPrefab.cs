using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToPrefab : MonoBehaviour
{
    
    public void Start()
    {
        // Add a random rotation to the prefab on start.
        transform.rotation = Random.rotation;
        // Create a random value for thrust and rotation values.
        float prefabThrust = Random.Range(100f, 1000f);
        // Assign the gameobjects rigidbody component to a temp rigidbody variable.
        Rigidbody r = GetComponent<Rigidbody>();
        // Add force to the rigidbody, use transform foward, not vector3 forward to use the rotation value.
        r.AddRelativeForce(transform.forward * prefabThrust);
        // Check value of thrust.
        Debug.Log(prefabThrust);
    }
}
