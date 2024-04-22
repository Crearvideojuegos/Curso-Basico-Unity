using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioJuego : MonoBehaviour
{
    public static AudioJuego Instance;
    public AudioClip SonidoPala;
    public AudioClip SonidoMuro;
    public AudioClip SonidoGol;
    public AudioClip SonidoVictoria;

    AudioSource audioSource;

    private void Awake() 
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void ReproducirSonidoPala()
    {
        audioSource.PlayOneShot(SonidoPala);
    }

    public void ReproducirSonidoMuro()
    {
        audioSource.PlayOneShot(SonidoMuro);
    }

    public void ReproducirSonidoGol()
    {
        audioSource.PlayOneShot(SonidoGol);
    }

    public void ReproducirSonidoVictoria()
    {
        audioSource.PlayOneShot(SonidoVictoria);
    }
  
}
