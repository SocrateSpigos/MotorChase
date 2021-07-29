using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySlowMo : MonoBehaviour
{
    public GameObject SlowMoTriggers;
    public GameObject Panel;
    public GameObject Cube;

    public void OnMouseDown()
    {

        Destroy(SlowMoTriggers);
        Destroy(Panel);
        Destroy(Cube);

    }
}
