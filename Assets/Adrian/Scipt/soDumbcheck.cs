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

        if(gameObject.transform.position.x != inventory.xtransform[position])
        {
            inventory.isFull[position] = false;
            
        }
        //else if (gameObject.transform.position.x != inventory.xtransform[1])
        //{
        //    inventory.isFull[1] = false;
        //}
        //else if (gameObject.transform.position.x != inventory.xtransform[2])
        //{
        //    inventory.isFull[2] = false;
        //}
        //Debug.Log("YES");
    }
    public void checkPos()
    {

        if (gameObject.transform.position.x == inventory.xtransform[0])
        {
            position = 0;

        }
        else if (gameObject.transform.position.x == inventory.xtransform[1])
        {
            position = 1;
        }
        else if (gameObject.transform.position.x == inventory.xtransform[2])
        {
            position = 2;
        }
        //Debug.Log("YES");
    }
}
