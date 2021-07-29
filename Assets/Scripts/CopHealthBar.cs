using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopHealthBar : MonoBehaviour
{

    public Image Bar;
    protected Image BarFilled;
    public GameObject BarPrefab;
    public Vector3 offset = new Vector3(0, 0, 0);
    public float Fill=1;


    // Start is called before the first frame update
    void Start()
    {
        Fill = 1f;
        Bar = Instantiate(BarPrefab, FindObjectOfType<Canvas>().transform).GetComponent<Image>(); 
        BarFilled = new List<Image>(Bar.GetComponentsInChildren<Image>()).Find(img => img != Bar);
    }

    void Update()
    {
        
            Bar.transform.position = Camera.main.WorldToScreenPoint(transform.position + offset);
            BarFilled.fillAmount = Fill;
        
        
        if (Fill <=0)
        {
            Destroy(Bar);
        }
    }

    public void OnMouseDown()
    {
        Fill -= 0.01f;
    }

    public void Die()
    {
        Fill -= 1;

    }
}
