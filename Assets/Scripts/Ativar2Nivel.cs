using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativar2Nivel : MonoBehaviour
{

    public Animator zigzag;
    public Animator lado;
    public Animator frente;
    public Animator idavolta;

    public GameObject eliminar;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("subiu");
        zigzag.SetBool("zigzag", true);
        idavolta.SetBool("idavolta", true);
        lado.SetBool("lado", true);
        frente.SetBool("frete", true);





        Destroy(eliminar);

    }
}