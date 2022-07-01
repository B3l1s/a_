using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioSource source;
    public AudioClip audioFX;


    public void OnGetbateria()
    {
        
            Destroy(gameObject);

        
        gameObject.SetActive(false);
        //mover sonido
        //posicion de la bateria
        source.transform.position = transform.position;


        //reproducir sonido
        source.PlayOneShot(audioFX);


    }



}
