using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemiController : MonoBehaviour
{
    [Header("Movimiento de Cam")]
    public Vector2 mouseMovimiento;
    public float RotateCameraX;
    public float RotatePlayerY;
    public float sencibility;

    

    [Header("Moment Controller")]
    public momentController Moment;
    public momentController Rotate;

    private void Update()
    {

        // movimiento del personje
        RotateCameraX = Input.GetAxis("Horizontal") *sencibility;
        RotatePlayerY = Input.GetAxis("Vertical") * sencibility;

        //almacenamiento del muose 
        RotateCameraX -= mouseMovimiento.y;

        //limitacion de la camara del eje x
       /* RotateCameraX = Mathf.Clamp(RotateCameraX, -40, 40);*/
      
        Moment.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        Rotate.Rotate(Input.GetAxis("Mouse X"));

    }

}
