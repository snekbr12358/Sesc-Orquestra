using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class tilesAction : MonoBehaviour
{
    public SpriteRenderer color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        color.color = Color.red;
    }
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if(color.color == Color.red)
        {
            Debug.Log("Você Acertou");
        }
        else if (colisao.collider.tag == "borda")
        {
            Debug.Log("Você Errou");
        }
    }
}
