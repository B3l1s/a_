using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(momentController))]

public class enemigoController : MonoBehaviour
{
    public momentController moment;
    private momentController rotate;
    public Transform juga;
    public float rangoOfDeteccion = 15f;

    public void Update()
    {

        float distance =  Vector3.Distance(transform.position, juga.transform.position);
        if(distance <= rangoOfDeteccion)
        {

            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 toOther = transform.position - juga.transform.position;
            if(Vector3.Dot(forward, toOther) < 1 )
            {
                print("a");
                moment.Rotate(-1);

            }
            if(Vector3.Dot(forward, toOther) > -1)
            {
                print("a");
                moment.Rotate(1);
            }




        }

    }
  
}
