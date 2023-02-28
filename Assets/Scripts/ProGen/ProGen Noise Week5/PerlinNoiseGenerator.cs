using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoiseGenerator : MonoBehaviour
{
    //Declare width and height (pixels) for new texure
    private int width = 1000;
    private int height = 200;

    void Start()
    {
        //Create a new texture
        Texture2D texture = new Texture2D(width, height);

        //Create new colour for the material
        Color color = new Color(0.5f, 0.2f, 0.8f);

        //Assign new colour for the material
        GetComponent<Renderer>().material.color = color;

        //Assign the texture to the material using the renderer component
        GetComponent<Renderer>().material.mainTexture = texture;


        //Look through each pixel in the texture using for loops on the x and y
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                //Calculate noise value of terain with PerlinNoise method using x and y co-ords
                float gradientValue = Mathf.PerlinNoise(x, y);

                //Set the pixel colour using the value from the Perlin Noise method
                texture.SetPixel(x, y, new Color(gradientValue, gradientValue, gradientValue));
            }
        }

        //Apply the changes to the new texture
        texture.Apply();


    }
}
