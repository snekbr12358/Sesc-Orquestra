using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CameraLenta : MonoBehaviour
{
    public float fatorDeEscalaDeTempo = 0.5f;

    public float tempoDeCooldown = 0.5f;

    public float duracaoC�meraLenta = 0.5f;

    public Button botaoC�meraLenta;
    
    private bool botaoPressionado = false;
    private bool c�meraLentaAtivada = false;
    private bool emCooldown = false;

    // Verifica��es por frame
    void Start()
    {       
        botaoC�meraLenta.onClick.AddListener(ToggleC�meraLenta);
    }
    void BotaoPressionado()
    {
        botaoPressionado = true;
    }

    void BotaoLiberado()
    {
        botaoPressionado = false;
    }

    void ToggleC�meraLenta()
    {
        if (botaoPressionado && !emCooldown)
        {
            Time.timeScale = fatorDeEscalaDeTempo;

            Invoke("ResetarC�mera", duracaoC�meraLenta);

            emCooldown = true;
            Invoke("ResetarCooldown", tempoDeCooldown);
            
            c�meraLentaAtivada = !c�meraLentaAtivada;

            
            Time.timeScale = c�meraLentaAtivada ? fatorDeEscalaDeTempo : 1.0f;
        }
    }
    void ResetarC�mera()
    {      
      Time.timeScale = 1.0f;
    }
    void ResetarCooldown()
    {        
      emCooldown = false;
    }
    void Update()
    {

    }

    public void FicaLento() { 
        Time.timeScale = 0.8f;
    }

}
