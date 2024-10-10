using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Barra : MonoBehaviour
{

    [SerializeField] private new Vector3 rotarse;
    [SerializeField] private float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotar();
       
    }
    void rotar()
    {

        transform.Rotate(rotarse * velocidad * Time.deltaTime, Space.World);
    }
}
