using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class precisaoo : MonoBehaviour
{

    public float precisao = 0f;


    void Update()
    {
        precisao = Contar.pontos / Arma.contadorbalas * 100;

        Debug.Log(precisao);
    }
}
