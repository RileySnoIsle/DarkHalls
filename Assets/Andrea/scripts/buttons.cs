using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
    public void play()
    {
        Debug.Log("play");
        SceneManager.LoadScene(0);
    }
}
