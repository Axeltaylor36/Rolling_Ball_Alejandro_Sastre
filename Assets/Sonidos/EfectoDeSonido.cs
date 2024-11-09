using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfectoDeSonido : MonoBehaviour
{

    private AudioSource audioSource;
    [SerializeField] private AudioClip colectar1;
    
    // Start is called before the first frame update;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
            if(other.CompareTag("Coleccionable"))
            {
                audioSource.PlayOneShot(colectar1);
            }
    }
}
