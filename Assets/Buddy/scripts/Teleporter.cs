using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    Rigidbody2D rb2;
    public GameObject Player;
    public GameObject Destination;
    public float posX;
    public float posY;


    // Update is called once per frame
    public void Update()
    {
        

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "MainJack")
        {
            Debug.Log("if this doesnt work, screw c#");

            transform.position = new Vector2(posX, posY );
            
        }


    }


}
