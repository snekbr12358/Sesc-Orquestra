using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CameraLenta : MonoBehaviour
{
    [SerializeField] float duracao;
    [SerializeField] float tempoCooldown;

    [SerializeField] bool ativar = false;
    [SerializeField] bool cooldown = false;

    float upgradeCooldown = 0;
    float duracaoTimer;
    float cooldownTimer;

    // Verificações por frame
    void Start()
    {       

    }

    void Update()
    {
        if (ativar && !cooldown) 
        {
            duracaoTimer += Time.deltaTime;
            FicaLento();
            if (duracaoTimer >= duracao) 
            {
                duracaoTimer = 0;
                cooldown = true;
                ativar = false;
                FicaNormal();
            }
        }
        if (cooldown) 
        { 
            cooldownTimer += Time.deltaTime;
            if (cooldownTimer >= tempoCooldown + upgradeCooldown) 
            {
                cooldownTimer = 0;
                cooldown = false;
            }
        }
    }

    void FicaLento() 
    { 
        Time.timeScale = 0.5f;
    }

    void FicaNormal() 
    {
        Time.timeScale = 1f;
    }

    public void AtivarCameraLenta() 
    {
        if (!cooldown) 
        {
            upgradeCooldown = PlayerPrefs.GetInt(TagsPlayerprefs.tagupgradeslowmotion);
            ativar = true;
        }
    }
   

}
