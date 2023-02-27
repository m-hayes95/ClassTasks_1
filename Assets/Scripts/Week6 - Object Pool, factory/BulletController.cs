using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] float speed = 10f; // Define speed variable for bullets.
    public float damage = 5f; // Define damage variable for bullets.
    [SerializeField] AudioSource bulletSound; // Define sound for bullets 

    public void Fire() // New method for fire function.
    {
        gameObject.SetActive(true); // Set bullet game object from list from false to true.
        // Add foward transform times speed variable and delta time to make it frame independant.
        transform.position += transform.forward * speed * Time.deltaTime;
        //play sound on fire
        bulletSound.Play();
    }
}
