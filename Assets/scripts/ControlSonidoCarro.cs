using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSonidoCarro : MonoBehaviour
{
    public AudioClip sonidoW;
    public AudioClip sonidoA;
    public AudioClip sonidoS;
    public AudioClip sonidoD;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            audioSource.clip = sonidoW;
            ReproducirSonido();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            audioSource.clip = sonidoA;
            ReproducirSonido();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.clip = sonidoS;
            ReproducirSonido();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            audioSource.clip = sonidoD;
            ReproducirSonido();
        }
    }

    void ReproducirSonido()
    {
        audioSource.Stop();
        audioSource.Play();
    }
}
