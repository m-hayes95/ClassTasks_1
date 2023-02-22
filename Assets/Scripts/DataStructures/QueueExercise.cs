using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueExercise : MonoBehaviour
{

    private void Update()
    {
        //Define a new queue of strings
        Queue<string> actions = new Queue<string>();

        //add actions of the same Datatype to the queue using the Enqueue method
        actions.Enqueue("Jump");
        actions.Enqueue("Shoot");
        actions.Enqueue("Dodge");
        
        //while loop to check the action count is currently more than 0
        while(actions.Count > 0)
        {
            //remove actions from the queue starting at 0 using the Dequeue method
            string action = actions.Dequeue(); 
            Debug.Log("Performing action " + action);
        }
    }
}
