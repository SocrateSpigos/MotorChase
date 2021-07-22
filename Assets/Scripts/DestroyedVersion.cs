using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedVersion : MonoBehaviour
{
    public GameObject cover;
    public float delay;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(cover, delay);
        }

    }
}
