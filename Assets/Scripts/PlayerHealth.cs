using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance
    {
        get;
        private set;
    }

    private float maxHP = 10f;
    public float hP;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        hP = maxHP;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Player hit" + collision.gameObject.name);

        if (collision.gameObject.CompareTag("Enemy"))
        {
            hP -= 1f;
        }
    }
}
