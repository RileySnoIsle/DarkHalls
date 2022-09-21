using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soDumbcheck : MonoBehaviour
{
    // Start is called before the first frame update
    public inventory inventory;
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();

    }
    public void Update()
    {
        Debug.Log(gameObject.transform.position.x);
      
    }
    // Update is called once per frame
    public void check()
    {
        if(gameObject.transform.position.x != inventory.xtransform[0])
        {
            inventory.isFull[0] = false;
            
        }
        else if (gameObject.transform.position.x != inventory.xtransform[1])
        {
            inventory.isFull[1] = false;
        }
        else if (gameObject.transform.position.x != inventory.xtransform[2])
        {
            inventory.isFull[2] = false;
        }
        Debug.Log("YES");
    }
}
