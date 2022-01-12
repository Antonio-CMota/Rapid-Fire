using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fim : MonoBehaviour
{

    public Animator fim;
    public GameObject eliminar;

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("abriu");
        fim.SetBool("fim", true);

    }
}
