using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TMP_Text meutext;
    public int scorepoints;

    public void PontosUpadate(int pontos)
    {
        scorepoints += pontos;
        meutext.text = scorepoints.ToString("Pontos: 0");  
    }
}
