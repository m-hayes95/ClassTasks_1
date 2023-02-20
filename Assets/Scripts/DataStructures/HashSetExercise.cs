using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashSetExercise : MonoBehaviour
{
    //define and initalise HashSet
    HashSet<string> words = new HashSet<string>() { "apple", "banana", "orange" };

    // Start is called before the first frame update
    void Start()
    {
        //check if HashTag contains a entry using the Contains() method
        if (words.Contains("banana"))
        {
            Debug.Log("Found Banana!!!");
        }

        //use a foreach loop to check the HashSet and print each element out
        foreach (string word in words)
        {
            Debug.Log(word);
        }
    }

    
}
