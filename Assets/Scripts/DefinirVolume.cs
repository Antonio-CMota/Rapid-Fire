using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DefinirVolume : MonoBehaviour
{

    public AudioSource audio;

    private float volumeMusica = 0.1f;

    private void Start()
    {
        audio.Play();
    }

    private void Update()
    {
        audio.volume = volumeMusica;
    }

    public void alterarVolume(float volume)
    {
        volumeMusica = volume;
    }
}
