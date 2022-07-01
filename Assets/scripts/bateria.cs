using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bateria : MonoBehaviour
{
    public AudioSource source;
    public AudioClip audioFX;
 
    public void TomarBateria()
    {

            //mover sonido
            //posicion de la bateria
        source.transform.position = transform.position;


            //reproducir sonido
        source.PlayOneShot(audioFX);

        gameObject.SetActive(false);
    }

}
