using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene1Manager : MonoBehaviour
{
    public Text textOnValue;
    public Text playerHPText;

    //private GameObject player;
    //public ConstantManagerScript constantManagerScript;

    // Start is called before the first frame update
    private void Start()
    {
        textOnValue.text = ConstantManagerScript.Instance.value.ToString();
        
        //player = GameObject.FindGameObjectWithTag("Player");
        //playerHPText.text = player.GetComponent<PlayerHealth>().hP.ToString();
    }

    private void Update()
    {
        //playerHPText.text = PlayerHealth.Instance.hP.ToString();
        //playerHPText.text = player.GetComponent<PlayerHealth>().hP.ToString();
    }


    public void GoToFirstScene()
    {
        SceneManager.LoadScene("SampleScene");
        ConstantManagerScript.Instance.value++;
    }

    public void GoToSecondScene()
    {
        SceneManager.LoadScene("Scene2");
        ConstantManagerScript.Instance.value++;
    }
    
}
