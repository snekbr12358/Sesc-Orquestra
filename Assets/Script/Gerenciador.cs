using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gerenciador : MonoBehaviour
{

    public float tilesVelocidade;

    // Start is called before the first frame update
    void Start()
    {
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
    //Vida
    public int vida = 10;

    //Dano

    //Verificar dano
    private void OnCollisionEnter2D(Collision2D colisao)
    {
        if(colisao.gameObject.tag == "inimigo")
        {
            vida--;
        }
    }
}
