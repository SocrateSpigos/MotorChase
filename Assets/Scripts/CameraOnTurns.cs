using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOnTurns : MonoBehaviour
{
    public Animator CamTurn;
    

    
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
