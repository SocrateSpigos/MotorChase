using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StickToTarget : MonoBehaviour
{
    public bool showTarget = false;
    protected Image Target;
    public GameObject TargetPrefab;
    public Transform trap;
    public Vector3 offset = new Vector3(0, 0, 0);

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            showTarget = true;
            Target = Instantiate(TargetPrefab, FindObjectOfType<Canvas>().transform).GetComponent<Image>();

        }
    }
    void Update()
    {
        if (showTarget)
        {

            Target.transform.position = Camera.main.WorldToScreenPoint(trap.transform.position + offset);
        }
    }
}
