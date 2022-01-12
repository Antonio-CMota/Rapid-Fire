using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morreraudio : MonoBehaviour
{

    public AudioSource morteaudio;

    public void Morrer()
    {
        morteaudio.Play();
    }
}
