using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PartituraButton : Button
{
    TextMeshProUGUI txtDescricaoLoja;
    Partitura partitura;
    public Loja loja;

    // Start is called before the first frame update
    void Start()
    {
        partitura = GetComponent<Partitura>();
        loja = FindObjectOfType<Loja>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
       
    }

    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        
    }

    public void ColocarNaFrente() 
    {
        transform.SetAsLastSibling();
        loja.MostraItens();
    }


}
