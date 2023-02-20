using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ArrayExercise : MonoBehaviour
{
    public int[] numbers = new int[5] { 10, 20, 30, 40, 50 };
    public int[] numbersCopy = new int [5] { 10, 20, 30, 40, 50};

    private void Update()
    {
        //use for loop to check over array and print each element to the console.
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }

        //use Squence Equal to compare the arrays.
        if (numbers.SequenceEqual(numbersCopy))
        {
            Debug.Log("The arrays are equal.");
        }
        else
        {
            Debug.Log("The arrays are not equal.");
        }

    }

    
}
