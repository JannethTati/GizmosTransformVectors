using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class DirectorVector : MonoBehaviour
{
    //Public Attributes

    public Transform finalTransform;
    public Transform initialTranform;
    public float speed = 1;
    //Private Attributes

    private Vector3 _directionVector;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Calculo del vector de direccion
        _directionVector = finalTransform.position - initialTranform.position;

        //Convierte el vector en unitario
        _directionVector.Normalize();

        //Dibujamos al vector
        Debug.DrawRay(initialTranform.position, _directionVector * speed);

        //Translate
        initialTranform.Translate(_directionVector * Time.deltaTime * speed);

        print("Magnitude: " + _directionVector.magnitude * speed);

        //Distance
        float distance = Vector3.Distance(initialTranform.position, finalTransform.position);
        print("Distance: " + distance);

        if (distance < 10 || distance > 20)
            speed *= -1;
        

         
    }
}
