using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{

    private bool tileRevelada = false;   //indica se a carta esta virada
    public Sprite originalCarta;         //Sprite da carta desejada
    public Sprite backCarta;             //Sprite da carta virada 

    // Start is called before the first frame update
    void Start()
    {
        EscondeCarta();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        print("Vou pressionar num Tile");
        /*if (tileRevelada)
        {
            EscondeCarta();
        }
        else
        {
            RevelaCarta();
        }*/                  //essa função não guardaba o número de cartas
        GameObject.Find("gameManager").GetComponent<ManagerCartas>().CartaSelecionada(gameObject);
    }

    public void EscondeCarta()
    {
        GetComponent<SpriteRenderer>().sprite = backCarta;
        tileRevelada = false;
    }

    public void RevelaCarta()
    {
        GetComponent<SpriteRenderer>().sprite = originalCarta;
        tileRevelada = true;
    }

    public void setCartaOriginal(Sprite novaCarta)
    {
        originalCarta = novaCarta;
    }

    
}
