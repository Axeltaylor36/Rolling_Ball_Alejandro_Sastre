using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamerespawn : MonoBehaviour
{
    [SerializeField] private float treshold;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (transform.position.y < treshold)
        {
            transform.position = new Vector3(6.08f, 133.9f, 33.7f);
            rb.isKinematic = true;
            rb.velocity = Vector3.zero;
            rb.isKinematic = false;
        }
    }
}
