using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Barco
{
    // Start is called before the first frame update
    void Start()
    {
        VidaMaxima = 100;
        vida = VidaMaxima;
        velocidade=1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        morrer();
        if(vida<=0){jogo.gameOver=true;}
        if(Input.GetKey(KeyCode.UpArrow)){
            andar_frente();
        }
        rotacionar(Input.GetAxis("Horizontal")*2f);
        if(Input.GetKeyDown(KeyCode.Return)){
            atirar_frontal();
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            atirar_lateral();
        }
        situacao_barco();
    }

}
