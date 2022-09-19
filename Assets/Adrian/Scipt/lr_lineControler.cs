using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lr_lineControler : MonoBehaviour
{
    // Start is called before the first frame update
    private LineRenderer lr;
    private Transform[] points;
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }
    public void SetUpLine(Transform[] points)
    {
        lr.positionCount = points.Length;
        this.points = points;
    }
    // Update is called once per frame
    void Update()
    {
        for (int i=0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
    }
}
