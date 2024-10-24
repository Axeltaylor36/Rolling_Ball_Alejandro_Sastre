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
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal , 0.0f, movimientoVertical);
        rbd.AddForce( movimiento * velocidad);
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
        bool resultado = Physics.Raycast(transform.position, Vector3.down, 0.3f);
        return resultado;
    }
}
