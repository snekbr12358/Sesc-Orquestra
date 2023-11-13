using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CameraLenta : MonoBehaviour
{
    public float fatorDeEscalaDeTempo = 0.5f;

    public float tempoDeCooldown = 0.5f;

    public float duracaoCâmeraLenta = 0.5f;

    public Button botaoCâmeraLenta;
    
    private bool botaoPressionado = false;
    private bool câmeraLentaAtivada = false;
    private bool emCooldown = false;

    // Verificações por frame
    void Start()
    {       
        botaoCâmeraLenta.onClick.AddListener(ToggleCâmeraLenta);
    }
    void BotaoPressionado()
    {
        botaoPressionado = true;
    }

    void BotaoLiberado()
    {
        botaoPressionado = false;
    }

    void ToggleCâmeraLenta()
    {
        if (botaoPressionado && !emCooldown)
        {
            Time.timeScale = fatorDeEscalaDeTempo;

            Invoke("ResetarCâmera", duracaoCâmeraLenta);

            emCooldown = true;
            Invoke("ResetarCooldown", tempoDeCooldown);
            
            câmeraLentaAtivada = !câmeraLentaAtivada;

            
            Time.timeScale = câmeraLentaAtivada ? fatorDeEscalaDeTempo : 1.0f;
        }
    }
    void ResetarCâmera()
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
