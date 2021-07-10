using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : MonoBehaviour
{
    public Animator bike;
    public Animator target1;
    public Animator target2;
    public string PathFollower;
    public GameObject biker;
    public GameObject cam;
    public GameObject ThirdCop;
    public ParticleSystem smokeTrail;

    // Start is called before the first frame update
    void Start()
    {
        bike = gameObject.GetComponent<Animator>();
        smokeTrail.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "KoliaLeft")
        {            smokeTrail.Play();

            bike.SetBool("KoliaLeft", true);
        }
        
        if (other.tag == "CopTrigger")
        {
            ThirdCop.SetActive(true);
        }
        
        

    }

    void OnTriggerExit(Collider other)
    {

        bike.SetBool("KoliaLeft", false);

        if (other.tag == "Arrest")
        {
            smokeTrail.Play();

            Debug.Log("Busted");
            bike.SetBool("Busted", true);
            GameObject.Find("Traffic_light").GetComponent<Animator>().enabled = false;



            StartCoroutine(BikeCoroutine());

        }

        if (other.tag == "KoliaLeft")
        {
            smokeTrail.Stop();
        }
        
        if (other.tag == "Target")
        {
            target1.SetBool("Active", true);
        }
        
        if (other.tag == "Target2")
        {
            Debug.Log("Hit");
            target2.SetBool("Active", true);
        }
    }

    IEnumerator BikeCoroutine()
    {

        yield return new WaitForSeconds(2f);
        (biker.GetComponent(PathFollower) as MonoBehaviour).enabled = false;
        (cam.GetComponent(PathFollower) as MonoBehaviour).enabled = false;
    }
}
