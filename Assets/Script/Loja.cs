using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Loja : MonoBehaviour
{

    public TextMeshProUGUI valorScore;

    //Variavel Texto de Valor de Coração

    public TextMeshProUGUI valorVida;

    //Informação do Banco

    private Banco MeuBanco;

    public GameObject comprar;
    public GameObject equipar;
    public GameObject preco;

    // Start is called before the first frame update
    void Start()
    {
      MeuBanco = GameObject.FindGameObjectWithTag("GameController").GetComponent<Banco>();
    }

    // Update is called once per frame
    void Update()
    {
        //informaçao do nivel da vida
        int vidascompradas = PlayerPrefs.GetInt("nivelVida") + 1;        
        int custo = (vidascompradas * 10);
        valorVida.text = " Vida LV: " + vidascompradas.ToString() + "$: " + custo.ToString();
        ScoreLoja();
    }
    //Realizar Comprar
    public void ComprarVida()
    {
        int vidascompradas = PlayerPrefs.GetInt("nivelVida") + 1;
        int custo = (vidascompradas * 10);
        if(vidascompradas <= 7)
        if(MeuBanco.Pagar(custo) == true ) 
        {
            //conseguiu compra
            PlayerPrefs.SetInt("nivelVida", vidascompradas);
        }
        else
        {
            //não conseguiu comprar
        }
    }
    public void ScoreLoja()
    {
        int score = PlayerPrefs.GetInt("minhasMoedas");
        valorScore.text = score.ToString();
        
    }
    public void MostraItens()
    {
        comprar.SetActive(true);
        equipar.SetActive(true);
        preco.SetActive(true);
    }



}
