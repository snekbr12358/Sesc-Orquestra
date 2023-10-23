using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilesAction : MonoBehaviour
{
    [SerializeField] private Sprite VerdeCerto;


    bool clicado = false;

    public int dano = 1;
    public SpriteRenderer color;
    public int ValorDaPontuçao = 1;

    float velocidade;

    Rigidbody2D rb;

    Gerenciador gj;

    Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
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
        

        if (gj != null && !clicado)
        {
            clicado = true;
            string tag = gameObject.tag;
            if (tag == "vermelha")
            {
                animator.SetBool("die", true);
                gj.PerderVida(dano);
            }
            else if (tag == "verde") 
            {
                animator.SetBool("die", true);
                gj.score.PontosUpadate(1);
            }
            
        }        
        Destroy(gameObject, 0.5f);
    }



}
