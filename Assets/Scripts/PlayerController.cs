using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 10f;
    private float horizontalInput;
    private float verticalInput;
    void Update()
    {
        //Detectar el Input Horizontal y Vertical
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Movimiento hacia delante manual
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
        /*
        Movimiento lateral manual
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
       */
        //Movimineto rotatorio manual
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
