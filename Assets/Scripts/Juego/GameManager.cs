using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private TextMeshProUGUI Txtpuntos;
    [SerializeField] private int puntos = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SumarPuntos(int cantidad)
    {
        puntos += cantidad;
        ActualizarUI();
    }    

    public void RestarPuntos(int cantidad)
    {
        puntos -= cantidad;
        ActualizarUI(); 
    }

    private void ActualizarUI()
    {
        Txtpuntos.text = puntos.ToString();
    }

    public void ReiniciarPuntos()
    {
        puntos = 0;
        ActualizarUI();
    }
    private void Awake()
    {
        if (Instance == null) 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

}
