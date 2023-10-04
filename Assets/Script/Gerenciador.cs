using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Gerenciador : MonoBehaviour
{
    public AudioSource audioSource;

    public TextMeshProUGUI txtvida;

    public int vidaInicial = 3; 
    public int vida;

    public float tilesVelocidade;

    public Score score;

    public GameObject GamerOver;

    private Banco MeuBnaco;

    Gerenciador gj;


    // Start is called before the first frame update
    void Start()
    {
        gj = FindAnyObjectByType<Gerenciador>();
        MeuBnaco = GetComponent<Banco>();
        vida = vidaInicial;
        Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        
        Time.timeScale = 1f;
        
    }
    public void Pause()
    {
        Time.timeScale = 0f;
    }
    public void Restart()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    
    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
    public void PerderVida(int quantidade)
    {
        vida -= quantidade;
        txtvida.text = vida.ToString(); 
        if(vida <= 0) 
        {
          audioSource.Stop();
          Time.timeScale = 0f;
          GamerOver.SetActive(true);
          
        }
    }
    public void tocarmusica()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogError("AudioSource não atribuído ao objeto do script de gerenciador.");
        }
    }
    public void ReceberMoedasdaMorreu(int n_moedas)
    {

    }
}
