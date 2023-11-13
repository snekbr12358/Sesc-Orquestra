using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CameraLenta : MonoBehaviour
{
    public float tempoDeCooldown = 5f;
    public float fatorDeEscalaDeTempo = 0.5f;

    public Button botaoCâmeraLenta;

    private bool emCooldown = false;
    private bool botaoPressionado = false;
    void Start()
    {
        
        botaoCâmeraLenta.onClick.AddListener(AtivarCâmeraLenta);
        botaoCâmeraLenta.onPointerUp.AddListener(DesativarCâmeraLenta);
    }
    void Update()
    {
             
    }
    void AtivarCâmeraLenta()
    {
        Time.timeScale = fatorDeEscalaDeTempo;
        if (!emCooldown)
        {
            // Altera a escala de tempo para criar o efeito de câmera lenta
            Time.timeScale = fatorDeEscalaDeTempo;

            // Inicia o cooldown
            emCooldown = true;

            // Agendamos o término do cooldown
            Invoke("ResetarCâmera", tempoDeCooldown);
        }
    }
    void DesativarCâmeraLenta()
    {
        // Quando o botão é solto, restaura imediatamente a escala de tempo
        Time.timeScale = 1.0f;
    }

    void ResetarCâmera()
    {
        // Restaura a escala de tempo
        Time.timeScale = 1.0f;

        // Reinicia o cooldown
        emCooldown = false;
    }
}

