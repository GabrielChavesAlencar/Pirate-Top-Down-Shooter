using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarcoShooter : Inimigo
{
    public float distan;
    // Start is called before the first frame update
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
            distan = distancia();
            if(distancia()>7){
                seguir();
            }
            else{
                atirar_frontal(1.5f);
            }
            olhar_player();
         }
    }
}
