using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : MonoBehaviour
{
    public Animator bike;
    public Animator target1;
    public Animator target2;
    public Animator target3;
    public string PathFollower;

    public GameObject biker;
    public GameObject cam;
    public GameObject ThirdCop;
    public GameObject FourthCop;
    public bool canShoot = true;
    public GameObject gun;

    public GameObject Camera;
    public Animator cameraAnim;
    
    public GameObject Canvas;
    public Animator canvas;
    public string LookAt;


    public ParticleSystem smokeTrail;

    // Start is called before the first frame update
    void Start()
    {

        cameraAnim = Camera.GetComponent<Animator>();
        canvas = Canvas.GetComponent<Animator>();
        bike = gameObject.GetComponent<Animator>();
        smokeTrail.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "KoliaLeft")
        {            
            smokeTrail.Play();

            bike.SetBool("KoliaLeft", true);
        }
        
        if (other.tag == "CopTrigger")
        {
            ThirdCop.SetActive(true);
        }
        
        if (other.tag == "SecondCopTrigger")
        {
            FourthCop.SetActive(true);
        }
        
        

    }

    void OnTriggerExit(Collider other)
    {

        bike.SetBool("KoliaLeft", false);

        if (other.tag == "Arrest")
        {
            smokeTrail.Play();
            canShoot = false;
            gun.SetActive(false);

            bike.SetBool("Busted", true);
            cameraAnim.SetBool("Busted", true);
            canvas.SetBool("Busted", true);
            
            (Camera.GetComponent(LookAt) as MonoBehaviour).enabled = false;

            GameObject.Find("Traffic_light").GetComponent<Animator>().enabled = false;


            StartCoroutine(BikeCoroutine());

        }

        if (other.tag == "Success")
        {
            smokeTrail.Play();

            bike.SetBool("Busted", true);

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
            
            if (other.tag == "Target3")
        {
            Debug.Log("Hit");
            target3.SetBool("Active", true);
        }
    }

    IEnumerator BikeCoroutine()
    {

        yield return new WaitForSeconds(2f);
        (biker.GetComponent(PathFollower) as MonoBehaviour).enabled = false;
        (cam.GetComponent(PathFollower) as MonoBehaviour).enabled = false;
    }
}
