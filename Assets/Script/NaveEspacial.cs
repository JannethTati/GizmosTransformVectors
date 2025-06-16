using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class NaveEspacial : MonoBehaviour
{

    public float energia;
    public float velocidad;
    public float armamento;

    private float _energia;
    private float _velocidad;
    private float _armamento;

    public void Acelera()

    {



    }

    public void Disparar(Arma arma)

    {

        arma.Disparar();

    }
}
