using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Loja : MonoBehaviour
{

    //Variavel Texto de Valor de Score

    public TextMeshProUGUI valorScore;

    //Variavel Texto de Valor de Coração

    public TextMeshProUGUI valorVida;

    public TextMeshProUGUI valorSlow;

    //Informação do Banco

    private Banco MeuBanco;

    public GameObject comprar;
    public GameObject equipar;
    public GameObject preco;

    public GameObject comprarD;
    public GameObject equiparD;
    public GameObject precoD;

    public CameraLenta cameraLenta;

    // Start is called before the first frame update
    void Start()
    {   
        MeuBanco = GameObject.FindGameObjectWithTag("GameController").GetComponent<Banco>();
    }

    // Update is called once per frame
    void Update()
    {
        //informaçao do nivel da vida
        int vidascompradas = PlayerPrefs.GetInt(TagsPlayerprefs.tagupgradevida) + 1;        
        int custovida = (vidascompradas * 10);
        valorVida.text = "VIDA LV: " + vidascompradas.ToString() + "$: " + custovida.ToString();
        

        int upgradeslowmotion = PlayerPrefs.GetInt(TagsPlayerprefs.tagupgradeslowmotion) + 1;
        int custoslow = (upgradeslowmotion * 10);
        valorSlow.text = "SLOWMOTION LV: " + upgradeslowmotion.ToString() + "$: " + custoslow.ToString();
        
        ScoreLoja();
    }
    //Realizar Comprar
    public void ComprarVida()
    {
        int vidascompradas = PlayerPrefs.GetInt(TagsPlayerprefs.tagupgradevida) + 1;
        int custo = (vidascompradas * 10);
        if(vidascompradas <= 7)
        if(MeuBanco.Pagar(custo) == true) 
        {
            //conseguiu compra
            PlayerPrefs.SetInt(TagsPlayerprefs.tagupgradevida, vidascompradas);
        }
        else
        {
            //não conseguiu comprar
        }
    }

    public void ComprarSlowMotion() 
    {
        int upgradeslowmotion = PlayerPrefs.GetInt(TagsPlayerprefs.tagupgradeslowmotion) + 1;
        int custo = (upgradeslowmotion * 10);
        if (upgradeslowmotion <= 3) 
        {
            if (MeuBanco.Pagar(custo) == true) 
            {
                PlayerPrefs.SetInt(TagsPlayerprefs.tagupgradeslowmotion, upgradeslowmotion);
            }
        }
    }

    public void ScoreLoja()
    {
        int score = PlayerPrefs.GetInt(TagsPlayerprefs.tagupgrademoeda);
        valorScore.text = score.ToString();
        
    }
    public void MostraItens()
    {
        comprar.SetActive(true);
        equipar.SetActive(true);
        preco.SetActive(true);
        comprarD.SetActive(true);
        equiparD.SetActive(true);
        precoD.SetActive(true);
    }
   

}
