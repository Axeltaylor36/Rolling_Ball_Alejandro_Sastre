using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimiento();
    }

    void movimiento()
    {
       transform.Translate (new Vector3(10, 0, 0) * 2 * Time.deltaTime);
    }
}
