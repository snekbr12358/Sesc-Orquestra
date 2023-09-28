using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilesAction : MonoBehaviour
{


    public int dano = 1;
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
        

        if (gj != null)
        {
            string tag = gameObject.tag;
            if (tag == "vermelha")
            {
                gj.PerderVida(dano);
            }
            else if (tag == "verde") 
            {
                gj.score.PontosUpadate(1);
            }
            
        }        
        Destroy(gameObject);
    }
}
