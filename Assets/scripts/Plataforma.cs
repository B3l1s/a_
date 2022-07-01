using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public GameObject plataforma;
    public Transform minPosition;
    public Transform maxPosition;

    public float speedMovimient;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag != null)
        {
            MoverPlataforma();
        }

    }

    private void MoverPlataforma()
    {

        plataforma.transform.Translate(Vector3.up * Time.deltaTime * speedMovimient);

        if(plataforma.transform.position.y >= maxPosition.transform.position.y && speedMovimient > 0)
        {
            speedMovimient = speedMovimient * -1;
        }

        if(plataforma.transform.position.y <= minPosition.transform.position.y && speedMovimient < 0)
        {
            speedMovimient = speedMovimient * -1;
        }

    }


}
