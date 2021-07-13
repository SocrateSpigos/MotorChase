using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Success : MonoBehaviour
{
    public Transform NewCameraPos;
    public Transform Camera;
    float Speed= 2f;
    private bool isLerp = false;

    public GameObject kissCine;
    public GameObject Player;
    public GameObject cam;
    public string PathFollower;




    public void Update()
    {
        if (isLerp)
        {
            (cam.GetComponent(PathFollower) as MonoBehaviour).enabled = false;

            PositionChanging();
            kissCine.SetActive(true);
            Player.SetActive(false);

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isLerp = true;
        }
        

    }



    void PositionChanging()
    {

        Camera.transform.position = Vector3.Lerp(Camera.position, NewCameraPos.position, Time.deltaTime * Speed);
        Camera.transform.rotation = Quaternion.Lerp(Camera.rotation, NewCameraPos.rotation, Time.deltaTime * Speed);

    }
}
