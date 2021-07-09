using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bike : MonoBehaviour
{
    public Animator bike;

    // Start is called before the first frame update
    void Start()
    {
        bike = gameObject.GetComponent<Animator>();

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "KoliaLeft")
        {
            bike.SetBool("KoliaLeft", true);

        }

    }

    void OnTriggerExit(Collider other)
    {

        bike.SetBool("KoliaLeft", false);



    }
}
