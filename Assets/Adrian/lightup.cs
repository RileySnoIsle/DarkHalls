using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lightup : MonoBehaviour
{
    // Start is called before the first frame update
    public slector slector;
    public Canvas canvas;
    public Image i1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(slector.item == this.gameObject)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(180, 180, 180);
        }
    }

    
}
