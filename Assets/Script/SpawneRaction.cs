using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawneRaction : MonoBehaviour
{
   
    public List<GameObject> Notas;
    public float tempo = 0;

    void Update()
    {
        QuedaRandomizada();


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
        if (tempo > 0.5f)
        {
            tempo = 0;
            //RandomizarPosição
            float posX = Random.Range(-2, 2);
            Vector3 novaPos = new Vector3(posX, 6, 0);
            //Randomizar o Objeto
            int probabilidade = Random.Range(0, 100);
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




        }
    }
}
