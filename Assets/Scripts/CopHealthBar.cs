using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopHealthBar : MonoBehaviour
{

    protected Image Bar;
    protected Image BarFilled;
    public GameObject BarPrefab;
    public Vector3 offset = new Vector3(0, 0, 0);
    public float Fill=1;
    private Image tempBar;
    private Image tempBar2;


    // Start is called before the first frame update
    void Start()
    {
        Fill = 1f;
        Bar = Instantiate(BarPrefab, FindObjectOfType<Canvas>().transform).GetComponent<Image>(); 
        BarFilled = new List<Image>(Bar.GetComponentsInChildren<Image>()).Find(img => img != Bar);
        /*tempBar = Bar;
        tempBar = BarFilled;*/

    }

    void Update()
    {
        
            Bar.transform.position = Camera.main.WorldToScreenPoint(transform.position + offset);
            BarFilled.fillAmount = Fill;
        
        
       
    }

    public void OnMouseDown()
    {
        Fill -= 0.01f;
        //Destroy(tempBar);
       // Destroy(tempBar2);

    }

    public void Die()
    {
        Fill -= 1;

    }
}
