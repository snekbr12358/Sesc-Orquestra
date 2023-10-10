using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banco : MonoBehaviour
{
    private int valorBanco;
    private const string moedasKey = "minhasMoedas";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void GuardarDinheiro(int novoValor)
    {
        //recebo oq eu ja tenho
        valorBanco = PlayerPrefs.GetInt(moedasKey);
        //Soma um novo valor
        valorBanco = valorBanco + novoValor;

        //Guarda
        PlayerPrefs.SetInt(moedasKey, valorBanco);

        PlayerPrefs.Save();
    }

    public int InformarValorBanco()
    {
        valorBanco = PlayerPrefs.GetInt(moedasKey);
        return valorBanco;
    }
}
