using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{

    public void Reiniciar(string Nombrenivel)
    {
        SceneManager.LoadScene(Nombrenivel);
    } 

    public void MenuInicial(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {
      
        Application.Quit();
    }
}
