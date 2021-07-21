using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopCar : MonoBehaviour
{
    public ParticleSystem smoke;
    public Animator copCar;

    public string PathFollower;
    public GameObject cop;
    public GameObject arrest;
    public GameObject arrest2;
    public GameObject arrest3;
    public GameObject success;
    public GameObject trafficLight;


    void Start()
    {
        smoke.Stop();
        copCar = gameObject.GetComponent<Animator>();

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "KoliaLeft")
        {
            copCar.SetBool("KoliaLeft", true);
            smoke.Play();
        }

        if (other.tag == "KoliaRight")
        {
            copCar.SetBool("KoliaRight", true);
            smoke.Play();

        }

        if (other.tag == "LampPost" || other.tag == "PipeTrap")
        {
            copCar.SetBool("Boom", true);
            //GameObject.Find("CopParent").GetComponent<Animator>().enabled = false;
            (cop.GetComponent(PathFollower) as MonoBehaviour).enabled = false;
            arrest.SetActive(false);

        }


        if (other.tag == "TrafficLight")
        {
            copCar.SetBool("Boom", true);
            arrest2.SetActive(false);
            //GameObject.Find("CopParent").GetComponent<Animator>().enabled = false;
            //(cop.GetComponent(PathFollower) as MonoBehaviour).enabled = false;

            StartCoroutine(CopCoroutine());
        }

            if (other.tag == "Bridge")
            {
            copCar.SetBool("Boom", true);
            Debug.Log("Bridge");
            (cop.GetComponent(PathFollower) as MonoBehaviour).enabled = false;
            arrest3.SetActive(false);
            success.SetActive(true);

        } 
        
        if (other.tag == "Arrest")
        {
            copCar.SetBool("Busted", true);
            //GameObject.Find("CopParent").GetComponent<Animator>().enabled = false;
            //(cop.GetComponent(PathFollower) as MonoBehaviour).enabled = false;
            trafficLight.SetActive(false);
            StartCoroutine(CopCoroutine());

        }

    }

    void OnTriggerExit(Collider other)
    {

        copCar.SetBool("KoliaLeft", false);
        copCar.SetBool("KoliaRight", false);
        smoke.Stop();


    }

    IEnumerator CopCoroutine()
    {

        yield return new WaitForSeconds(2f);
        (cop.GetComponent(PathFollower) as MonoBehaviour).enabled = false;
    }
}
