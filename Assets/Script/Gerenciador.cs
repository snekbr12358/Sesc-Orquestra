using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Gerenciador : MonoBehaviour
{
    public SceneManager SceneManager;

    Banco banco;

    public AudioSource audioSource;

    public TextMeshProUGUI txtvida;

    private int vidaInicial = 3; 
    private int vida;
    private int vidasCompradas;
    
    public float tilesVelocidade;

    public Score score;

    public GameObject GamerOver;
    public GameObject TelaVitoria;
    public GameObject GameMenu;

    private int pontostotais;

    // Start is called before the first frame update
    void Start()
    {
        banco = GetComponent<Banco>();     
        Pause();
    }

    void MusicaFim() 
    {
        audioSource.Stop();
        Time.timeScale = 0f;
        TelaVitoria.SetActive(true);
        score.MostrarScoreWin();
        Debug.Log(banco.InformarValorBanco());
        banco.GuardarDinheiro(score.scorepoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
       Inicializar();
       Time.timeScale = 1f;
       Invoke("MusicaFim", audioSource.clip.length);
    }
    public void Pause()
    {
       Time.timeScale = 0f;
    }
    public void Restart()
    {
       banco.GuardarDinheiro(score.scorepoints);
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
            score.MostrarScoreGameOver();
            banco.GuardarDinheiro(score.scorepoints);
            Debug.Log(banco.InformarValorBanco());
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
    public void InciarGame()
    {
        SceneManager.LoadScene(0);
    }
    public void TentarNovamente()
    {
        GamerOver.SetActive(false);
        TelaVitoria.SetActive(false);
        tocarmusica();
        vida = vidaInicial;
        txtvida.text = vida.ToString();
        score.ResetarScore();
        deletarTiles();
        Play();
    }
    public void Inicializar()
    {
        int vidas_compradas = PlayerPrefs.GetInt("nivelVida");
        vida = vidaInicial + vidas_compradas;
        txtvida.text = vida.ToString();
        
    }
    public int InformaVida()
    {
        return vida;
    }

    void deletarTiles()
    {
        GameObject[] verdes = GameObject.FindGameObjectsWithTag("verde");
        
        for (int i = 0; i < verdes.Length; i++)
        {
            Destroy(verdes[i]);
        }

        //GameObject.FindGameObjectsWithTag("verde");
        GameObject[] vermelhas = GameObject.FindGameObjectsWithTag("vermelha");

        for (int i = 0; i < vermelhas.Length; i++)
        {
            Destroy(vermelhas[i]);
        }

    }
    public void Resume()
    {
        GamerOver.SetActive(false);
        TelaVitoria.SetActive(false);
        tocarmusica();
        vida = vidaInicial;
        txtvida.text = vida.ToString();
        score.ResetarScore();
        Play();
    }

}
