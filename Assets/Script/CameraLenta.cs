using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CameraLenta : MonoBehaviour
{
    public float fatorDeEscalaDeTempo = 0.5f;

    public float tempoDeCooldown = 0.5f;

    public Button botaoCâmeraLenta;
    
    private bool botaoPressionado = false;
    
    private bool emCooldown = false;

    // Verificações por frame
    void Start()
    {       
        botaoCâmeraLenta.onClick.AddListener(ToggleCâmeraLenta);
    }
    void ToggleCâmeraLenta()
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
        if (botaoCâmeraLenta.IsPressed() && !emCooldown)
        {
            ToggleCâmeraLenta();
        }
    }
}
