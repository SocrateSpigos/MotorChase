using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastMo : MonoBehaviour
{
    public float faster;
    
    void Update()
    {
        Time.timeScale = Time.timeScale * faster;
    }
}
