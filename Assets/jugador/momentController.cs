using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class momentController : MonoBehaviour
{
    

    [Header("movimiento del personaje")]
    public float speedmovimiento;
    public Vector3 direccion;
    public CharacterController controller;



    [Header("Rotate")]
    public float RotatePlayerY;

    [Header("salto del jugador")]
    public float JumpHeight;
    public Vector2 desplazamiento_Y;
    public float gravity = -9.8f;

    private void Update()
    {
        /*// movimiento del personje
        direccion.x = Input.GetAxis("Horizontal");
        direccion.z = Input.GetAxis("Vertical");

        //transformar direccion de coordenadas del jugador
       

        //almacenamiento del muose 
        RotateCameraX -= mouseMovimiento.y;
        RotatePlayerY += mouseMovimiento.x;

        //movimiento del jugador con los input

        mouseMovimiento.x = Input.GetAxis("Mouse X");
        mouseMovimiento.y = Input.GetAxis("Mouse Y");*/

        //move el personaje 
        controller.Move(direccion * Time.deltaTime * speedmovimiento);

        /*//limitacion de la camara del eje x
        RotateCameraX = Mathf.Clamp(RotateCameraX, -40, 40);

        //rotar el personaje con base del jugador acomulado
        playerCamera.transform.localRotation = Quaternion.Euler(RotateCameraX, 0, 0);

        //rotar el persaje con base del movimiento acumulado
        controller.transform.rotation = Quaternion.Euler(0, RotatePlayerY, 0);*/



        //calcular gravedad en cada frame
        //desplazamiento_Y.y += Gravity * Time.deltaTime;

        //mover en personaje en "y" en base  a  la gravedad calculadad
       // controller.Move(desplazamiento_Y * Time.deltaTime);

        //si esta tocansdo el suelo en Y es negativo resetar la gravedad
        if (controller.isGrounded && direccion.y < 0)

        {
            desplazamiento_Y.y = -2f;
        }
        direccion = transform.TransformDirection(direccion);

        //sie le personaje esta tocando el suelo y al presinar la tecla, calcaular el salto del personaje
        if (controller.isGrounded && Input.GetButton("Jump"))
        {
            desplazamiento_Y.y = Mathf.Sqrt(JumpHeight * -2f * gravity);
        }


        
    }
    public void Move(float Horizontal, float Vertical)
    {
        direccion.x = Horizontal;
        direccion.z = Vertical;

        direccion = transform.TransformDirection(direccion);
        controller.Move(direccion * Time.deltaTime * speedmovimiento);
    }
    public void Rotate(float RotateVuler)
    {
        RotatePlayerY += RotateVuler;
        controller.transform.rotation = Quaternion.Euler(0, RotatePlayerY, 0);

    }
}



