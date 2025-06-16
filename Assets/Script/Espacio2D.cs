using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Espacio2D : MonoBehaviour
{
    //Atributes
    //Public

    public Transform playerTransform;
    public Transform sphereTransform;
    public float speedZ;
    public float speedY;
    public float speedRotation;
    public float speedRotationSphere;

    //Private 
    private float rotationAngle = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento en 2 ejes
        //playerTransform.Translate(0, Time.deltaTime * speedY, Time.deltaTime * speedZ);

        //Movimiento en 2 ejes
        playerTransform.Translate(Vector3.forward * Time.deltaTime * speedZ);//Time.deltaTime = 1 / 300
        playerTransform.Translate(Vector3.up * Time.deltaTime * speedY);

        //Rotacion en 1 eje
        //playerTransform.Rotate(speedRotation * Time.deltaTime, 0, 0);
        playerTransform.Rotate(Vector3.right * speedRotation * Time.deltaTime);

        //Rotate Arround
        sphereTransform.RotateAround(playerTransform.position, Vector3.forward, rotationAngle * Time.deltaTime * speedRotationSphere);

        rotationAngle++;
    }
}
