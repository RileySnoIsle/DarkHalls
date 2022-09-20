using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Txtbox : MonoBehaviour
{
  
    public UnityEngine.UI.Text textbox;
    bool wasActive = false;

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            if (textbox != null)
            {
                bool wasActive = textbox.gameObject.activeSelf;
                textbox.gameObject.SetActive(!wasActive);
            }
        }
        
    }
}
