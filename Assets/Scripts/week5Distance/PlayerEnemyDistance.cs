using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnemyDistance : MonoBehaviour
{
    //ref to actors
    [SerializeField] private GameObject player, enemy;
    //check distance at specified range
    [SerializeField] private float distanceCheckPoint1 = 20f, distanceCheckPoint2 = 10f, distanceCheckPoint3 = 1f;
    //bool to check if distance has been reached
    [SerializeField] private bool checkPoint1 = false, checkPoint2 = false, checkPoint3 = false;
    //ref to enemy renderer
    [SerializeField] private MeshRenderer enemyRenderer;

    private void Update()
    {
        //check distance between 2 actors with Vector3.Distance method
        float distance = Vector3.Distance(player.transform.position, enemy.transform.position);
        Debug.Log("Distance between Player and game object is " + distance);

        //if the distance is less than or equal to the corresponding distance check point
        if (distance <= distanceCheckPoint1 && !checkPoint1)
        {
            //set checkpoint 1 bool to true
            Debug.Log("Player has passed checkpoint 1 ");
            checkPoint1 = true;
            //change the render of the enemy to a cylinder material once CP1 has been reached
            enemyRenderer.material = Resources.Load<Material>("Cylinder Material");
        }
        
        if (distance <= distanceCheckPoint2 && !checkPoint2)
        {
            //set checkpoint 2 bool to true
            Debug.Log("Player has passed checkpoint 2 ");
            checkPoint2 = true;
            //change the render of the enemy to a square material once CP2 has been reached
            enemyRenderer.material = Resources.Load<Material>("Cube Material");
        }
       
        if (distance <= distanceCheckPoint3 && !checkPoint3)
        {
            //set checkpoint 3 bool to true
            Debug.Log("Player has passed checkpoint 3 ");
            checkPoint3 = true;
            //change the render of the enemy to a sphere material once CP3 has been reached
            enemyRenderer.material = Resources.Load<Material>("Sphere Material");
        }
        

    }
}
