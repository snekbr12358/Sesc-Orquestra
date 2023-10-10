using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTiles : MonoBehaviour
{
    Gerenciador gj;

    // Start is called before the first frame update
    void Start()
    {
        gj = FindAnyObjectByType<Gerenciador>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if(colisao.gameObject.tag == "verde" ) 
        {
            gj.PerderVida(1);
        }
        Destroy(colisao.gameObject);
    }
}
