using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativar3Nivel : MonoBehaviour
{

    public Animator movimentoc;
    public Animator xantares;
    public Animator idavoltaa;
    public Animator cimabaixo;

    public Animator tanque;
    public Animator parede;

    public GameObject eliminar;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("subiu");
        movimentoc.SetBool("movimentoc", true);
        xantares.SetBool("xantares", true);
        idavoltaa.SetBool("idavoltaa", true);
        cimabaixo.SetBool("cimabaixo", true);

        tanque.SetBool("tanque", true);
        parede.SetBool("parede", true);



        Destroy(eliminar);

    }
}