using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Gerenciador : MonoBehaviour
{
    public TextMeshProUGUI txtvida;

    public int vidaInicial = 3; 
    private int vida;

    public float tilesVelocidade;

    public Score score;


    // Start is called before the first frame update
    void Start()
    {
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
    public void PerderVida(int quantidade)
    {
        vida -= quantidade;
        txtvida.text = vida.ToString();
    }
    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }

   
}
