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
    }

    // Update is called once per frame
    void Update()
    {
        if(vida<=0){vida=0;}
        if(Input.GetKey(KeyCode.UpArrow)){
            andar_frente();
        }
        rotacionar(Input.GetAxis("Horizontal"));
        if(Input.GetKeyDown(KeyCode.Return)){
            atirar_frontal();
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            atirar_lateral();
        }
        situacao_barco();
    }

}
