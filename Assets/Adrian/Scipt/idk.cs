using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class idk : MonoBehaviour
{
    public GameObject Player;
    public GameObject door;
    public Canvas canvas;
    private void Start()
    {
        
    }
    public void openDoor()
    {
        

        float x = Player.transform.position.x;
        float y = Player.transform.position.y;

        float doorx = door.transform.position.x;
        float doory = door.transform.position.y;

        float dis = Mathf.Abs(Mathf.Sqrt(Mathf.Pow(x-doorx, 2) + Mathf.Pow(y-doory,2)));

        if(dis < 1)
        {
            door = GameObject.FindGameObjectWithTag("Door");
            door.GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            Debug.Log("Not close enough, Get: " + dis.ToString());

        }

    }
}
