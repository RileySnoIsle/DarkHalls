using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public int num = 0;
    public List<float> xtransform;
    public List<float> ytransform;

    private void Start()
    {
        
        foreach(GameObject value in slots)
        {
            xtransform.Add(value.transform.position.x);
            ytransform.Add(value.transform.position.y);
            
        }
        
    }
}
