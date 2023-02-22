using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExercise : MonoBehaviour
{
    void Update()
    {
        //define a new stack with the string datatype
        Stack<string> history = new Stack<string>();

        //using the Push method to the stack using the same datatype
        history.Push("Page1");
        history.Push("Page2");
        history.Push("Page3");
        history.Push("Page4");

        //use while loop to check the current count is more than 0
        while (history.Count > 0)
        {
            //using the Pop method, remove fields from the stack in the reverse order
            string page = history.Pop();
            Debug.Log("Viewing page " + page);

        }
    }
}
