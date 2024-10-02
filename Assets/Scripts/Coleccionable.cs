using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coleccionable : MonoBehaviour
{

    
    [SerializeField] private Vector3 direccion;
    //[SerializeField] float direccion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(direccion * Time.deltaTime, Space.World);
    }

   
}
