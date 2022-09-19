using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slector : MonoBehaviour
{

    public static GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
  
        item = this.gameObject;
    }
}
