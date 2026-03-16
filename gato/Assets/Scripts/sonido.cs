using UnityEngine;

public class sonido : MonoBehaviour
{
    public AudioClip sonidoX;
    public AudioClip sonidoO;
    public AudioClip sonidoBoton;
    public AudioClip sonidoFinJuego;


    private AudioSource audioSource;

    void Start(){
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayX(){
        audioSource.PlayOneShot(sonidoX);
    }

    public void PlayO(){
        audioSource.PlayOneShot(sonidoO);
    }

    public void PlayBoton(){
        audioSource.PlayOneShot(sonidoBoton);
    }

    public void PlayFinJuego(){
        audioSource.PlayOneShot(sonidoFinJuego);
    }
}
