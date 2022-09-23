using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragBox : MonoBehaviour
{
    public GameObject parent;
    private inventory inventory;
    private float startPoxX;
    private float startPosY;
    private bool isBeingHeld = false;
    private soDumbcheck soDumbcheck;
    public GameObject mainCamera;
    private System.Nullable<Vector3> _movementDestination;

    public void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        Debug.Log(mainCamera.tag);
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
        soDumbcheck = GameObject.FindGameObjectWithTag("Player").GetComponent<soDumbcheck>();
    }
    private void Update()
    {
       
        if (isBeingHeld == true)
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
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        Debug.Log(mainCamera.name);

        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Left");
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPoxX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            isBeingHeld = true;
            GameObject.FindGameObjectWithTag("Player").GetComponent<BoxCollider2D>().enabled = false ;

        }
        
    }

    private void OnMouseUp()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<BoxCollider2D>().enabled = true;
        isBeingHeld = false;
        //inventory.isFull[0] = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
        gameObject.GetComponent<soDumbcheck>().check();
        //Debug.Log(gameObject);
        //Debug.Log(gameObject.GetComponent<soDumbcheck>().position);
        //Debug.Log(mainCamera.transform.GetChild(gameObject.GetComponent<soDumbcheck>().position));
        mainCamera.transform.GetChild(gameObject.GetComponent<soDumbcheck>().position).gameObject.transform.DetachChildren();
        
        
    }
    
}
