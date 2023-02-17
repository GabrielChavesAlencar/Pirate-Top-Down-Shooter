using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : Inimigo
{
    // Start is called before the first frame update
    //public radar rad;
    void Start()
    {
        VidaMaxima = 100;
        vida = VidaMaxima;
        velocidade=0.8f;
    }

    // Update is called once per frame
    void Update()
    {
        morrer();
        situacao_barco();
        
         if(rad.dentro){
            seguir();
            olhar_player();
         }
    }

}
