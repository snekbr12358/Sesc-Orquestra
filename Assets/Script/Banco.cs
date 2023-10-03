using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banco : MonoBehaviour
{
    private int valorBanco;

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
        valorBanco = PlayerPrefs.GetInt("minhasMoedas");
        //Soma um novo valor
        valorBanco = valorBanco + novoValor;

        //Guarda
        PlayerPrefs.SetInt("minhasmoedas", novoValor);
    }
    public int InformarValorBanco()
    {
        valorBanco = PlayerPrefs.GetInt("minhasMoedas");
        return valorBanco;
    }
}
