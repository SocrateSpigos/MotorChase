using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnTurns : MonoBehaviour
{
    public Animator CamTurn;
    public Transform Cinematic;
    public Transform Bike;
    public float Speed = 3f;



    void Start()
    {
        PositionChanging();
    }


    void PositionChanging()
    {

        Cinematic.transform.position = Vector3.Lerp(Cinematic.position, Bike.position, Time.deltaTime * Speed);
        Cinematic.transform.rotation = Quaternion.Lerp(Cinematic.rotation, Bike.rotation, Time.deltaTime * Speed);

    }
    void OnTriggerEnter(Collider other)
    {


        if (other.tag == "KoliaLeft")
        {
            CamTurn.SetBool("Left", true);
        }
        
        if (other.tag == "KoliaRight")
        {
            CamTurn.SetBool("Right", true);
        }


    } 
    
    void OnTriggerExit()
    {
        CamTurn.SetBool("Left", false);
        CamTurn.SetBool("Right", false);

    }




}
