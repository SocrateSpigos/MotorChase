using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyedVersion : MonoBehaviour
{
    public GameObject destroyedVersion;

        void OnMouseDown()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
