using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TMP_Text meutext;
    public int scorepoints;

    public TMP_Text TXTscoreGameOver;

    public TMP_Text TXTscoreWin;
    
    public void ResetarScore() {
        scorepoints = 0;
        meutext.text = scorepoints.ToString(":0");
    }
    public void PontosUpadate(int pontos)
    {
        scorepoints += pontos;
        meutext.text = scorepoints.ToString(":0"); 
        
    }

    public void MostrarScoreGameOver() 
    { 
        TXTscoreGameOver.text = scorepoints.ToString(":0");
    }

    public void MostrarScoreWin()
    {
        TXTscoreWin.text = scorepoints.ToString(":0");
    }

}
