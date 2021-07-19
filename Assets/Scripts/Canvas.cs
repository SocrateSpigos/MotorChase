using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Canvas : MonoBehaviour
{

    public Bike bike;
    public GameObject Restart;
    public GameObject Continue;

    void Update()
    {
        if (bike.isLerp)
        {
            StartCoroutine(RestartCoroutine());

        } 
        
        if (bike.isSuccess)
        {
            StartCoroutine(ContinueCoroutine());

        }
    }


    public void RestartButton()
    {
        SceneManager.LoadScene("TestingScene");
    }

    IEnumerator RestartCoroutine()
    {

        yield return new WaitForSeconds(2f);
        Restart.SetActive(true);

    }
    
    IEnumerator ContinueCoroutine()
    {

        yield return new WaitForSeconds(2f);
        Continue.SetActive(true);

    }
}
