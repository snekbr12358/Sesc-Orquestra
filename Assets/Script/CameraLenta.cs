using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CameraLenta : MonoBehaviour
{
    public float tempoDeCooldown = 5f;
    public float fatorDeEscalaDeTempo = 0.5f;

    public Button botaoC�meraLenta;

    private bool emCooldown = false;
    private bool botaoPressionado = false;
    void Start()
    {
        
        botaoC�meraLenta.onClick.AddListener(AtivarC�meraLenta);
        botaoC�meraLenta.onPointerUp.AddListener(DesativarC�meraLenta);
    }
    void Update()
    {
             
    }
    void AtivarC�meraLenta()
    {
        Time.timeScale = fatorDeEscalaDeTempo;
        if (!emCooldown)
        {
            // Altera a escala de tempo para criar o efeito de c�mera lenta
            Time.timeScale = fatorDeEscalaDeTempo;

            // Inicia o cooldown
            emCooldown = true;

            // Agendamos o t�rmino do cooldown
            Invoke("ResetarC�mera", tempoDeCooldown);
        }
    }
    void DesativarC�meraLenta()
    {
        // Quando o bot�o � solto, restaura imediatamente a escala de tempo
        Time.timeScale = 1.0f;
    }

    void ResetarC�mera()
    {
        // Restaura a escala de tempo
        Time.timeScale = 1.0f;

        // Reinicia o cooldown
        emCooldown = false;
    }
}

