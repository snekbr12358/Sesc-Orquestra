using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public AudioSource audioSource;
    bool clicado = false;
    Gerenciador gj;

    public bool GameLigado = false;
    public GameObject pauseMenu;


    // Start is called before the first frame update
    void Start()
    {
        
        gj = FindAnyObjectByType<Gerenciador>();
    }

    // Update is called once per frame
    void Update()
    {
       
           
    }
    void OnMouseDown()
    {
    }
    public void pausargame()
    {

        if (gj != null && !clicado)
        {
            clicado = true;
            pauseMenu.gameObject.SetActive(false);
            Time.timeScale = 1;
            GameLigado = true;
        }
        else
        {
            audioSource.Stop();
            pauseMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
            GameLigado = false;
            
        }
    }
   
}
