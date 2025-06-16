using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyName : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(new Vector2(0, 0), new Vector2(2, 2));
        Debug.DrawLine(new Vector2(2, 2), new Vector2(0, 4));
        Debug.DrawLine(new Vector2(0, 4), new Vector2(2, 6));
    }
}
