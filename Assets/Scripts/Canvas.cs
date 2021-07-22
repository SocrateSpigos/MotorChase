using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Canvas : MonoBehaviour
{
    public Success success;
    public Bike bike;
    public GameObject Restart;
    public GameObject Continue;

    void Update()
    {
        if (bike.isLerp)
        {
            StartCoroutine(RestartCoroutine());

        } 
        
        if (success.isSuccess)
        {
            Debug.Log("IsSuccess");
            StartCoroutine(ContinueCoroutine());

        }
    }


    public void RestartButton()
    {
        SceneManager.LoadScene("Level1");
    }
    
    public void ContinueButton()
    {
        SceneManager.LoadScene("Level2");
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
        Debug.Log("SetActive");


    }
}
