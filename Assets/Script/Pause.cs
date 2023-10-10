using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
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
        if (gj != null && !clicado)
        {
            clicado = true;
            pauseMenu.gameObject.SetActive(false);
            Time.timeScale = 1;
            GameLigado = true;
        }
        else
        {
            pauseMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
            GameLigado = false;
        }
    }
   
}
