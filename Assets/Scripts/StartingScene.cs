using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingScene : MonoBehaviour
{
    public Transform Camera;
    public Transform NewCameraPos;
    public GameObject CineCam;
    public GameObject MainCam;
    public float Speed;
    private bool isLerp = false;
    public string LookAt;
    public string TargetSelector;
    public GameObject camera;
    public GameObject panel;



    void Start()
    {
        StartCoroutine(StartingCoroutine());
        StartCoroutine(CamCoroutine());

    }

    void Update()
    {
        if (isLerp)
        {
            PositionChanging();
        }

    }


    void PositionChanging()
    {    
            Camera.transform.position = Vector3.Lerp(Camera.position, NewCameraPos.position, Time.deltaTime * Speed);
            Camera.transform.rotation = Quaternion.Lerp(Camera.rotation, NewCameraPos.rotation, Time.deltaTime * Speed);

    }

    

    IEnumerator StartingCoroutine()
    {
        yield return new WaitForSeconds(2f);
        isLerp = true;
        (camera.GetComponent(LookAt) as MonoBehaviour).enabled = true;
        panel.SetActive(false);
        (MainCam.GetComponent(TargetSelector) as MonoBehaviour).enabled = true;

    }

    IEnumerator CamCoroutine()
    {
        yield return new WaitForSeconds(5f);
        CineCam.SetActive(false);


    }

}
