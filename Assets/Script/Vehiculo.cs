using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Vehiculo : MonoBehaviour
{
    
    
    public string modelo;
    public string color;
    private int _cantidadGasolina = 1000;
    private float _velocidadActual = 0;


    //Metodos 

    private void Update()
    {
        ControlarGasolina();
        Acelerar(1);
    }

    
  
    public void Acelerar(float velocidad)
    {

        _velocidadActual += velocidad ;
        print("El coche de color " + color + "tiene una Velocidad actual: " + _velocidadActual);
        _cantidadGasolina--;

    }

    private void ControlarGasolina()
    {

        if (_cantidadGasolina <= 0)
            Parar();
    
    }
    public void Parar()
    { 


    
    }
    public void Arrancar()
    {

    }

}
