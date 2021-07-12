using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    Camera cam;
    private float mouse;
    public GameObject shoot;
    
    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    
    void Update()
    {
        mouse = Input.mousePosition.x;
        transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5));


        Destroy(shoot, 2f);


        if (Input.GetKey(KeyCode.Mouse0))

        {
            Instantiate(shoot, transform.position, transform.rotation);
        }

    }

}
