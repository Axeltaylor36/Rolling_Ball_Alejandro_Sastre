using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour
{
    // Start is called before the first frame update

    public float jumpForce = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {

            collision.gameObject.GetComponent<Rigidbody>().velocity = (Vector3.up * jumpForce);

        }
    }
}
