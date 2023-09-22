                                                                           

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawneRaction : MonoBehaviour
{
    public float larguraw = 10;
    public float alturah = 5;
    public List<GameObject> Notas;
    public float tempo = 0;

    void Update()
    {
        QuedaRandomizada();


    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(larguraw, alturah, 0));
    }


    void QuedaSimples()
    {
        tempo += Time.deltaTime;
        if (tempo > 0.5f)
        {
            tempo = 0;
            //RandomizarPosição
            float posX = Random.Range(-2, 2);
            Vector3 novaPos = new Vector3(posX, 6, 0);
            //Randomizar o Objeto
            int indice = Random.Range(0, Notas.Count);
            GameObject novaNota = Instantiate(Notas[indice], novaPos, Quaternion.identity);
            Destroy(novaNota, 2f);
        }
    }

    void QuedaRandomizada()
    {
        tempo += Time.deltaTime;
        if (tempo > 1)
        {
            tempo = 0;
            //RandomizarPosição
            float posX = Random.Range(-2, 2);
            Vector3 novaPos = new Vector3(posX, 13, 0);
            //Randomizar o Objeto
            int probabilidade = Random.Range(0, 106);
            if (probabilidade < 12)
            {
                GameObject novaNota = Instantiate(Notas[0], novaPos, Quaternion.identity);
                Destroy(novaNota, 2f);
            }else if (probabilidade < 24)
            {
                GameObject novaNota = Instantiate(Notas[1], novaPos, Quaternion.identity);
                Destroy(novaNota, 2f);
            }
            else if (probabilidade < 36)
            {
                GameObject novaNota = Instantiate(Notas[2], novaPos, Quaternion.identity);
                Destroy(novaNota,  2f);
            }
            else if (probabilidade < 48)
            {
                GameObject novaBolinha = Instantiate(Notas[3], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            else if (probabilidade < 55)
            {
                GameObject novaBolinha = Instantiate(Notas[4], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            else if (probabilidade < 75)
            {
                GameObject novaBolinha = Instantiate(Notas[5], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            else if (probabilidade < 85)
            {
                GameObject novaBolinha = Instantiate(Notas[6], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            else if (probabilidade < 90)
            {
                GameObject novaBolinha = Instantiate(Notas[7], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            else if(probabilidade < 95)
            {
                GameObject novaBolinha = Instantiate(Notas[8], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            else if (probabilidade < 100)
            {
                GameObject novaBolinha = Instantiate(Notas[9], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            else if (probabilidade < 105)
            {
                GameObject novaBolinha = Instantiate(Notas[10], novaPos, Quaternion.identity);
                Destroy(novaBolinha, 2f);
            }
            




        }
    }
}
