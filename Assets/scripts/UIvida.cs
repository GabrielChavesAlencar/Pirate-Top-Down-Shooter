using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIvida : MonoBehaviour
{
    public Barco barco;
    public SpriteRenderer render;
    public float tamanho_incial;
    public float tamanho_certo;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<SpriteRenderer>();
        tamanho_incial = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if(barco.vida>60){
            render.color = new Color(0.287f,1,0.344f,1);
        }
        else if(barco.vida<=60&&barco.vida>30){
            render.color = new Color(0.99f,0.73f,0.09f,1);
        }
        else if(barco.vida<=30){
            render.color = new Color(1,0.11f,0,1);
        }
        tamanho_certo =tamanho_incial*barco.vida/barco.VidaMaxima;
        transform.localScale = new Vector3(tamanho_certo,0.95f,1);
    }
}
