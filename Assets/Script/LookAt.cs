using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    // Public Attributes
    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Target x: " + target.position.x + " / Target y: " + target.position.y + " / Target z: " + +target.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.position);
    }
}
