using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Transform cameraPlyer;
    public Transform objetoVacio;
    public Transform objetoVacioArma;
    public LayerMask im;
    public float RayDistancia;


    private void Update()
    {

        if(Input.GetButtonDown("Botton E"))
        {
            if(objetoVacio.childCount > 0)
            {
                objetoVacio.GetComponentInChildren<Rigidbody>().isKinematic = false;
                objetoVacio.DetachChildren();
                if (objetoVacioArma.childCount > 0)
                {
                    objetoVacioArma.GetChild(0).gameObject.SetActive(true);
                }

            }
            else
            {
                Debug.DrawRay(cameraPlyer.position, cameraPlyer.forward * RayDistancia, Color.red);
                if (Physics.Raycast(cameraPlyer.position, cameraPlyer.transform.forward, out RaycastHit hit, RayDistancia, im))
                {
                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;
                    hit.transform.parent = objetoVacio;
                    hit.transform.localPosition = Vector3.zero;
                    // hit.transform.localRotation = Quaternion.Euler(Vector3.zero);
                    hit.transform.localRotation = Quaternion.Euler(0, 0, 0);
                    if(objetoVacioArma.childCount > 0)
                    {
                        objetoVacioArma.GetChild(0).gameObject.SetActive(false);
                    }
                }

            }

        }
       
    }




    public Estadistica estadistica;

    public void OnTriggerEnter(Collider other)
    {
       /* if (other.transform.tag == " Door")
        {
            Debug.Log(other.transform.name);
        }*/

        if (other.tag == " Door" /*&& estadistica.count_bateria >= 1*/)
        {
            Debug.Log("entra");
            other.GetComponentInParent<AnimationDoor>().OpenDoor();
           

        }


        if (other.tag == "Bateria")
        {
            other.GetComponent<bateria>().TomarBateria();
            estadistica.count_bateria++;


        }

        if (other.tag == "arma")
        {
            other.transform.parent = objetoVacioArma;
            other.transform.localRotation = Quaternion.identity;
            other.transform.localPosition = Vector3.zero;
            if (objetoVacio.childCount > 0)
            {
                other.gameObject.SetActive(false);
            }

        }


    }
}


