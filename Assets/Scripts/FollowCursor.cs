using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    Camera cam;
    private float mouse;
    public GameObject shoot;
    public GameObject bike;
    public bool shootDisabled;

    void Start()
    {
        cam = GameObject.Find("MainCamera").GetComponent<Camera>();
        shootDisabled = bike.GetComponent<Bike>().canShoot;
    }
    
    void Update()
    {
        mouse = Input.mousePosition.x;
        transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5));


        Destroy(shoot, 2f);


        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (!shootDisabled)
            {
                Instantiate(shoot, transform.position, transform.rotation);
            }
         
        }

    }

}
