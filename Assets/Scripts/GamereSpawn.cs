using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamerespawn : MonoBehaviour
{
    [SerializeField] private float treshold;
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }
}
