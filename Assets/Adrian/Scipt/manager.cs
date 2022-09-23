using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject frame1;
    public GameObject frame2;
    public GameObject frame3;
    public GameObject indicator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (frame1.GetComponent<requiredColor>().correct == true &&
            frame2.GetComponent<requiredColor>().correct == true &&
            frame3.GetComponent<requiredColor>().correct == true)
        {
            indicator.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);
        }
    }
}
