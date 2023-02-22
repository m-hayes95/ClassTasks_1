
using System.Collections.Generic;
using UnityEngine;

public class DictionaryExercise : MonoBehaviour
{
    //define and initalise new dictionary 
    Dictionary<string, int> ages = new Dictionary<string, int>()
    {
        {"John", 25 },
        {"Mary", 30 },
        {"Bob", 35 }
    };

    // Start is called before the first frame update
    void Start()
    {
        //retrieve value for mary using the index operator
        int maryAge = ages["Mary"];
        
        Debug.Log("Mary's age is" + maryAge);

        //use foreach loop to check over ages dict and print each key-value pair
        foreach (KeyValuePair<string, int> pair in ages)
        {
            Debug.Log(pair.Key + " is " + pair.Value);
        }
    }

}
