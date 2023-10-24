using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Loja : MonoBehaviour
{
    //Variavel Texto de Valor de Coração

    public TextMeshProUGUI valorVida;

    //Informação do Banco

    private Banco MeuBanco;

    // Start is called before the first frame update
    void Start()
    {
      MeuBanco = GameObject.FindGameObjectWithTag("GameController").GetComponent<Banco>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Realizar Comprar
    public void ComprarVida()
    {
        int vidascompradas = PlayerPrefs.GetInt("nivelVida") + 1;
        int custo = (vidascompradas * 10);
        if (MeuBanco.Pagar(custo) == true)
        {
            //conseguiu compra
            PlayerPrefs.SetInt("nivelVida", vidascompradas);
        }
        else
        {
            //não conseguiu comprar
        }
    }
}
