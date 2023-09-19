using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilesAction : MonoBehaviour
{
    public SpriteRenderer color;
    public int ValorDaPontuçao = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            color.color = Color.red;
            FindObjectOfType<Score>().PontosUpadate(ValorDaPontuçao);
        }
    }
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (color.color == Color.red)
        {
            Debug.Log("Você Acertou");
        }
        else if (colisao.collider.tag == "borda")
        {
            Debug.Log("Você Errou");
        }
    }

}
