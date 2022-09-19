using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    private inventory inventory;
    public GameObject itemButton;
    public Button button;
    // Start is called before the first frame update
    
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
        button.GetComponent<Button>().interactable = false;
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
                    button.GetComponent<Button>().interactable = true;

                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
