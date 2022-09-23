using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    private inventory inventory;
    public GameObject itemButton;
    public id id;
    private GameObject child;
    //public Button button;
    // Start is called before the first frame update
    
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
        //button.GetComponent<Button>().interactable = false;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if(inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    //Instantiate(itemButton, new Vector3(inventory.xtransform[i], inventory.ytransform[i], 0), Quaternion.identity);
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    //button.GetComponent<Button>().interactable = true;
                    
                    
                    
                    

                    Destroy(gameObject.gameObject);
                    break;
                }
            }
        }
    }
}
