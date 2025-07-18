using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gizmos : MonoBehaviour
{
    //Public Attributes
    public Vector2 point1;
    public Vector2 point2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Draw Line
        Debug.DrawLine(point1, point2, Color.red);

        //Draw X
        //Debug.DrawLine(new Vector2(0, 0), new Vector2(2, 2));
        //Debug.DrawLine(new Vector2(2, 0), new Vector2(0, 2));

        //Draw Ray 
        //local Axis of the cube
        Debug.DrawRay(transform.position, transform.up, Color.green);
        Debug.DrawRay(transform.position, transform.right, Color.red);
        Debug.DrawRay(transform.position, transform.forward, Color.blue);
    }
}
