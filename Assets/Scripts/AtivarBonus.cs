using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarBonus : MonoBehaviour
{

    public Animator dumy;

    public levantaraudio levantaraudio; 

    public GameObject eliminar;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("subiu");
        dumy.SetBool("dumy", true);

        levantaraudio.Levantar();




        Destroy(eliminar);

    }
}