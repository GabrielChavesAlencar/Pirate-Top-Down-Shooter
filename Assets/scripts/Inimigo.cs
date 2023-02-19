using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : Barco
{
    // Start is called before the first frame update
    public radar rad;
    public bool morto;
    
    public float distancia () {
        return Vector3.Distance(transform.position, rad.player.transform.position);
    }
    public void seguir () {
        
        andar_frente();
       
        
    }
    
    public void olhar_player () {
        if(vida>0){
            Vector2 direcao =  rad.player.transform.position-transform.position;
            float angulo = Mathf.Atan2(direcao.y, direcao.x) * Mathf.Rad2Deg - 90f;
            GetComponent<Rigidbody2D>().rotation = angulo;
        }
    }
   
    public virtual void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="Player"){
            other.gameObject.GetComponent<Player>().vida-=30;
            GameObject temp = Instantiate(explosao);
            temp.transform.position= transform.position;
            Destroy(gameObject);
        }
    }
    public virtual void somar_potuacao(){
        if(!morto){
            if(vida<=0){
                jogo.Score+=10;
                morto=true;
            }
        }        
    }
}
