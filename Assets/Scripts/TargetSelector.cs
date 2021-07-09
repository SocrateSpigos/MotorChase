using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSelector : MonoBehaviour
{
    public Camera camera;
    public Transform player;
    public ParticleSystem gunFire;
    public GameObject light;


    void Start()
    {
        gunFire.Stop();
        light.SetActive(false);
    }

    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            gunFire.Play();
            light.SetActive(true);


            Ray ray = camera.ScreenPointToRay(Input.mousePosition);


            if(Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if (hitInfo.collider.gameObject.GetComponent<ChangeColor>() !=null)
                {
                    Vector3 distanceToTarget = hitInfo.point - transform.position;
                    Vector3 forceDirection = distanceToTarget.normalized;
                    Debug.Log("Clicked");
                }
            }
        }
        else
        {
            gunFire.Stop();
            light.SetActive(false);

        }
    }


     
}
