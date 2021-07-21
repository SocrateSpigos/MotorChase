using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject cop;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            cop.SetActive(true);
        }
    }
}
