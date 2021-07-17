using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetUI : MonoBehaviour
{
    public GameObject TargetPrefab;
    protected Image Target;

    void Start()
    {
        Target = Instantiate(TargetPrefab, FindObjectOfType<Canvas>().transform).GetComponent<Image>();

    }

    void Update()
    {
        Target.transform.position = Camera.main.WorldToScreenPoint(transform.position + new Vector3(0, 0, 0));

    }
}
