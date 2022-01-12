using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativar : MonoBehaviour
{

    public Animator subir;
    public GameObject eliminar;
    public Animator camiao;
    public GameObject arma;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("subiu");
        subir.SetBool("subir", true);
        camiao.SetBool("camiao", true);

        arma.SetActive(true);


    }




}
