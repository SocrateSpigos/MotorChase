using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnim : MonoBehaviour
{
    public Animator anim;

    public void OnMouseDown()
    {
        anim.SetBool("Active", true);
    }
}
