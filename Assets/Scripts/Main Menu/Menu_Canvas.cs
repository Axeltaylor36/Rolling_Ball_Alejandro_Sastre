using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu_Canvas: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EmpezarNivel(string Nombrenivel)
    { 
        SceneManager.LoadScene(Nombrenivel);
    }
    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo...");
    }
}
