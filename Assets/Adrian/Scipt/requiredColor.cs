using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class requiredColor : MonoBehaviour
{
    // Start is called before the first frame update
    public int color;
    private GameObject child;
    public manager manager;
    public bool correct = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.childCount > 0)
        {
            Debug.Log("Has Child");
            child = gameObject.transform.GetChild(0).gameObject;
            if(child.GetComponent<id>().ID == color)
            {
                correct = true;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.parent == null && collision.GetComponent<id>().ID == color)
        {
            correct = true;
            collision.GetComponent<BoxCollider2D>().enabled = false;
        }
       

    }
    //if (gameObject.transform.childCount > 0)
    //    {
    //        Debug.Log("Has Child");
    //        child = gameObject.transform.GetChild(0).gameObject;
    //        if (child.GetComponent<id>().ID == color)
    //        {
    //            correct = true;
    //        }
    //    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.childCount > 0)
        {
            Debug.Log("Has Child");
            collision.transform.GetChild(0).GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
