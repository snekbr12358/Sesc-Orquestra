using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilesAction : MonoBehaviour
{
    public SpriteRenderer color;
    public int ValorDaPontu�ao = 1;
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
            FindObjectOfType<Score>().PontosUpadate(ValorDaPontu�ao);
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (color.color == Color.red)
        {
            Debug.Log("Voc� Acertou");
        }
        else if (colisao.collider.tag == "borda")
        {
            Debug.Log("Voc� Errou");
        }
    }

}
