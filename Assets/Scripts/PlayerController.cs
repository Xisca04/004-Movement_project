using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 10f;
    private float horizontalInput;
    void Update()
    {
        //Movimiento hacia delante
        //transform.Translate(0, 0, 1);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
       
        //Detectar el Input Horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        //Movimiento lateral manual
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);
    }
}
