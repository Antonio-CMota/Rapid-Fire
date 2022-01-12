using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tirosaudio : MonoBehaviour
{

    public AudioSource audiotiros;

    public void Disparar()
    {
            audiotiros.Play();
    }
}
