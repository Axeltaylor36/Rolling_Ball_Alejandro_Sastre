using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private Vector3 sentido = new Vector3(0, 0, 0);
    [SerializeField] private float CambioDireccion;
    private float timer;

    private bool cambiarDireccion;

    [SerializeField] private Vector3 direccion;
    //[SerializeField] float direccion;
    // Start is called before the first frame update
    void Start()
    {
        sentido = sentido.normalized;
        timer = CambioDireccion;
        cambiarDireccion = false;
    }

    // Update is called once per frame
    void Update()
    {
        Temp();
        transform.Rotate(direccion * Time.deltaTime, Space.World);
    }

    void Temp()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            if (cambiarDireccion)
            {
                cambiarDireccion = false;
            }

            else
            {
                cambiarDireccion = true;
            }
            sentido = sentido * -1;
            timer = CambioDireccion;
        }

        transform.Translate(direccion * velocidad * Time.deltaTime, Space.World);
    }

   
}
