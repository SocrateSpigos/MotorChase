using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    Camera cam;
    private float mouse;
    
    
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    
    void Update()
    {
        mouse = Input.mousePosition.x;
        transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5));


        if (mouse < 400) ;
        {
            Debug.Log(Input.mousePosition.x);
        }

        /*if (Input.GetKey(KeyCode.Mouse0))
        {
            if(Input.mousePosition.x > 250);
            {
                Debug.Log("Right");
                Debug.Log(Input.mousePosition.x);

            }

            if (Input.mousePosition.x < 250) ;
            {
                Debug.Log("Left");
                Debug.Log(Input.mousePosition.x);
            }
         }*/


    }

}
