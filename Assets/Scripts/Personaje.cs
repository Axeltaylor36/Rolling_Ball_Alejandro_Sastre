using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    Rigidbody rbd;
    [SerializeField] private float velocidad, fuerzaSalto;
    Vector3 posInicial;
    [SerializeField] Vector3 moverseW1, moverseS2, moverseA3, moverseD4;


    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();
        posInicial = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();
        
        if (DetectarSuelo() == true)
        {
            salto();
        }
            
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

    void salto()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            rbd.AddForce(Vector3.up * fuerzaSalto , ForceMode.Impulse);
        }
    } 
    bool DetectarSuelo()
    {
        bool resultado = Physics.Raycast(transform.position, Vector3.down, 2f);
        return resultado;
    }
}
