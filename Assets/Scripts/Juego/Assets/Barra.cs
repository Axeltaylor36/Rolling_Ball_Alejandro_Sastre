using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Barra : MonoBehaviour
{

    [SerializeField] private new Vector3 rotarse;
    [SerializeField] private float velocidad;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Rotation();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void rotar()
    {

        transform.Rotate(rotarse * velocidad * Time.deltaTime, Space.World);
    }

    void Rotation()
    {
        rb.AddTorque(rotarse * velocidad, ForceMode.VelocityChange);
    }
}
