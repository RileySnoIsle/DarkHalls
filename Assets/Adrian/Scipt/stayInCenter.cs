using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stayInCenter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject p1, p2, p3;
    public GameObject inta;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xpos = (p1.transform.position.x + p2.transform.position.x + p3.transform.position.x) / 3;
        float ypos = (p1.transform.position.y + p2.transform.position.y + p3.transform.position.y) / 3;

        inta.transform.position = new Vector3(xpos, ypos, 0);
    }
}
