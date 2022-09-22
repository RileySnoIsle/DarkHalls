using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragBox : MonoBehaviour
{
    private inventory inventory;
    private float startPoxX;
    private float startPosY;
    private bool isBeingHeld = false;
   

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
    }
    private void Update()
    {
        if(isBeingHeld == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPoxX, mousePos.y - startPosY, 0);
        }
       
    }

    private void OnMouseDown()
    {
        
        gameObject.GetComponent<soDumbcheck>().checkPos();
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPoxX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            isBeingHeld = true;
            //GameObject.FindGameObjectWithTag("Player").GetComponent<CircleCollider2D>().enabled = false ;

        }

    }

    private void OnMouseUp()
    {
       // GameObject.FindGameObjectWithTag("Player").GetComponent<CircleCollider2D>().enabled = true;

        isBeingHeld = false;
        //inventory.isFull[0] = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        gameObject.GetComponent<soDumbcheck>().check();
    }
}
