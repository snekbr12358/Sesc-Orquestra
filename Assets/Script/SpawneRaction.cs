using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawneRaction : MonoBehaviour
{
    public float larguraw = 10;
    public float alturah = 5;
    public GameObject pianotile;
    public float delay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        Spawner();
        spawnuntill();
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(larguraw, alturah, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (verificacaoVazio())
        {
            spawnuntill();
        }
    }
    void spawnuntill()
    {
        Transform position = freeposition();
        if (position)
        {
            GameObject piano = Instantiate(pianotile, position.transform.position, Quaternion.identity);
            piano.transform.parent = position;
        }
        if (freeposition())
        {
            Invoke("spawnuntill",delay);
        }
    }
    void Spawner()
    {
        foreach(Transform child in transform)
        {
            GameObject piano = Instantiate(pianotile, child.position, Quaternion.identity);
            piano.transform.parent = child;
        }
    }
    bool verificacaoVazio()
    {
        foreach (Transform child in transform)
        {
            if(child.childCount > 0)
            {
                return false;
            }
        }
        return true;
    }
    Transform freeposition()
    {
        foreach (Transform child in transform)
        {
            if (child.childCount == 0)
            {
                return child;
            }
        }
        return null;
    }
}
