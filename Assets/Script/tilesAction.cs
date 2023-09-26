using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilesAction : MonoBehaviour
{
    public SpriteRenderer color;
    public int ValorDaPontuçao = 1;
    float velocidade;
    Rigidbody2D rb;
    Gerenciador gj;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gj = FindAnyObjectByType<Gerenciador>();
        velocidade = gj.tilesVelocidade;
        rb.velocity = Vector2.down * velocidade;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        color.color = Color.red;
        FindObjectOfType<Score>().PontosUpadate(ValorDaPontuçao);
        Destroy(gameObject);
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
