using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableRigidBody : MonoBehaviour
{
    void OnMouseDown()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(-500f, 200f, 500f));
        //rigidbody.isKinematic = false;
    }
}
