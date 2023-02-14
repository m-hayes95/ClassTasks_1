using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public CounterCubeScript theCounterCube;
    public int coinsCollected = 0; //declared and assigned in a single line
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        theCounterCube = FindObjectOfType<CounterCubeScript>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = 6.0f;

        //Player Movement Code
        //read the input of the horizontal and vertical, store them in a variabl
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //Debug.Log("The vertical is " + verticalInput + " and the horizontal is " + horizontalInput);
        Vector3 inputFromPlayer = new Vector3(horizontalInput, 0, verticalInput);

        //move the player based on the values
        transform.Translate(inputFromPlayer * speed * Time.deltaTime);

        //theCounterCube.theCounter
        Debug.Log("The counter cube has" + theCounterCube.theCounter + "_counts.");
        
        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Player Input = Jump");
            //Set cube red
            theCounterCube.SetColourRed();
        }
    }

    
}
