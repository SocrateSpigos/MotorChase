using UnityEngine;

public class SlowMo : MonoBehaviour
{

    public float slowdownFactor=0.05f;
    public float slowdownLength ;

 
    void Update()
    {
        Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }

    public void DoSlowmotion ()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("SlowMotion1");

        if (other.tag == "Player")
        {
            Debug.Log("SlowMotion");
            DoSlowmotion();

        }
    }
}
