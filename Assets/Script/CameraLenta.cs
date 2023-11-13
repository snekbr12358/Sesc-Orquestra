using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CameraLenta : MonoBehaviour
{
    public float fatorDeEscalaDeTempo = 0.5f;

    public float tempoDeCooldown = 0.5f;

    public Button botaoC�meraLenta;
    
    private bool botaoPressionado = false;
    
    private bool emCooldown = false;

    // Verifica��es por frame
    void Start()
    {       
        botaoC�meraLenta.onClick.AddListener(ToggleC�meraLenta);
    }
    void ToggleC�meraLenta()
    {       
        if (!emCooldown)
        { 
            
          if (Time.timeScale == 1.0f)
          {
            Time.timeScale = fatorDeEscalaDeTempo;
                
            emCooldown = true;
            Invoke("ResetarCooldown", tempoDeCooldown);              
          }
          else
          {               
            Time.timeScale = 1.0f;
          }
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
        if (botaoC�meraLenta.IsPressed() && !emCooldown)
        {
            ToggleC�meraLenta();
        }
    }
}
