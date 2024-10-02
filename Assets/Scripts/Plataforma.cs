using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    [SerializeField] private float temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimiento();
        timer();
    }

    void movimiento()
    {
       transform.Translate (new Vector3(10, 0, 0) * 2 * Time.deltaTime);
    }

    void timer() 
    {
        if (temp >= 2)
        {
          temp += 1 * Time.deltaTime;
        }
    }
}