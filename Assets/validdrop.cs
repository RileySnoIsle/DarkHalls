using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class validdrop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Trigger");

        //if(collision.GetComponent<requiredColor>().color == gameObject.GetComponent<id>().ID)
        //{
        //    collision.GetComponent<requiredColor>().correct = true;
        //}

    }
}
