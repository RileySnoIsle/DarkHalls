using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    Rigidbody2D rb2;
    public GameObject Player;
    public GameObject Destination;
    
    // Start is called before the first frame update
    public void Start()
    {
        
        


    }

    // Update is called once per frame
    public void Update()
    {
        





    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "MainJack")
        {
            Debug.Log("if this doesnt work, screw c#");

            //transform.localPosition = new ;
        }


    }


}
