using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListExercise : MonoBehaviour
{
    private void Start()
    {
        //Define & initalize list of ints.
        List<int> numbers = new List<int> ();

        //use Add to add numbers to the list.
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        //print out the list of numbers using a foreach loop.
        foreach (int number in numbers)
        {
            Debug.Log (number);
        }
    }

    
}
