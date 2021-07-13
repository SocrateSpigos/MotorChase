using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeCollapse : MonoBehaviour
{
    public GameObject leftPillar;
    public GameObject rightPillar;
    public Animator bridge;

    void Update()
    {
      if (leftPillar.activeInHierarchy && leftPillar.activeInHierarchy )
        {
          bridge.SetBool("Active",true);
        }
    }
}
