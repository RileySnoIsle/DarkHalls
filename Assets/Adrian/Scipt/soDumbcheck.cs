using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soDumbcheck : MonoBehaviour
{
    // Start is called before the first frame update
    public inventory inventory;
    public int position;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();

    }
    public void Update()
    {
        //Debug.Log(gameObject.transform.position.x);
      
    }
    // Update is called once per frame

    public void check()
    {
        if(position != -1) {
            if (gameObject.transform.parent.name == "slot1") 
            {
                inventory.isFull[0] = false;
                gameObject.GetComponent<dragBox>().enabled = false;

            }
            if (gameObject.transform.parent.name == "slot2")
            {
                inventory.isFull[1] = false;
                gameObject.GetComponent<dragBox>().enabled = false;

            }
            if (gameObject.transform.parent.name == "slot3")
            {
                inventory.isFull[2] = false;
                gameObject.GetComponent<dragBox>().enabled = false;

            }

        }
        
        //Debug.Log("YES");
    }
    public void checkPos()
    {

        if (gameObject.transform.parent.name == "slot1")
        {
            position = 0;
            gameObject.GetComponent<dragBox>().enabled = true;

        }
        else if (gameObject.transform.parent.name == "slot2")
        {
            position = 1;
            gameObject.GetComponent<dragBox>().enabled = true;
        }
        else if (gameObject.transform.parent.name == "slot3")
        {
            position = 2;
            gameObject.GetComponent<dragBox>().enabled = true;
        }
        else
        {
            position = -1;
        }

        //Debug.Log("YES");
    }
}
