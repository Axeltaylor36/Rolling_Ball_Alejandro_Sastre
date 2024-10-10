using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float velocidad, velocidadSalto;
    Vector3 posInicial;
    [SerializeField] Vector3 moverseW1, moverseS2, moverseA3, moverseD4;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
    }

    void Movimiento()
    {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(moverseW1.normalized * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(moverseA3.normalized * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(moverseS2.normalized * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moverseD4.normalized * velocidad * Time.deltaTime);
        }
    }
}
