using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    [SerializeField] float valorTiempo;
    float tiempo;
    [SerializeField] new Vector3 moverse;
    [SerializeField] new Vector3 rotarse;
    [SerializeField] int velocidad;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       Mover();
       Rotar();
       FinTiempo();
    }

     void Mover()
    {
        transform.Translate(moverse * velocidad * Time.deltaTime, Space.World);
    }
    void Rotar()
    {
        transform.Rotate (rotarse * 90 * Time.deltaTime, Space.World);
    }

    void FinTiempo()
    {
        tiempo -= Time.deltaTime;
        if (tiempo <= 0)
        {
            moverse = moverse * -1;

            tiempo = valorTiempo;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

}
