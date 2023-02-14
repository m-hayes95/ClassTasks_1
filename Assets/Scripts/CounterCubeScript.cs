using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterCubeScript : MonoBehaviour
{
    public int theCounter;

    public Renderer r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
        r.material.color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SetColourRed()
    {
        r.material.color = Color.red;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("something has entered the trigger, it was" + other.name);

        if (other.name == "PlayerMC")
        {
            //it was the player that entered the countercube
            Debug.Log("The PlayerMC has hit the cube");

            //Get a refernence to the player's player script
            Player thePlayerScript = other.gameObject.GetComponent<Player>();
            //add to the value of coins collected on the player script
            thePlayerScript.coinsCollected++;
     
        }
    }
}
