using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemRespawn : MonoBehaviour
{

    [SerializeField] Transform posRespawn;
    [SerializeField] Transform posPlayer;
    [SerializeField] GameObject Personaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeadPlayer ()
    {
        posPlayer.position = posRespawn.position;

    }
}
