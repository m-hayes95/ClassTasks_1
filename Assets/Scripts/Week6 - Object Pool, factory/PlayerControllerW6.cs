using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerW6 : MonoBehaviour
{
    public ObjectPool objectPool; // Ref to object pool list on bullet controller class.
    public KeyCode fireKey = KeyCode.Space; // Ref to space key input.

    private void Update()
    {
        if (Input.GetKeyDown(fireKey)) // If input for fire is called.
        {
            // Obtain a bullet from the object pool of bullet game objects.
            GameObject bullet = objectPool.bullets.Find(b => !b.activeInHierarchy);
            if (bullet != null)
            {
                // Call fire method from the bullet controller script if bullet is not null.
                bullet.GetComponent<BulletController>().Fire(); 
            }
        }
    }
}
