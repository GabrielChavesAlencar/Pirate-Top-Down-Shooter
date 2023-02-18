using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barco : MonoBehaviour
{
    public int vida;
    public int VidaMaxima;
    public GameObject projetil;
    public GameObject local_intancia;
    public GameObject local_intancia2;
    public GameObject local_intancia3;
    protected bool atirar_normal;
    protected bool atirar_especial;
    protected SpriteRenderer render;
    public Sprite [] estados_barco;
    public float velocidade;
    public GameObject explosao;
    public float tempo_morrer;
    


    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void andar_frente () {
        if(vida>0){
        transform.Translate(0,Time.deltaTime*velocidade,0);
       }
    }

    public void rotacionar ( float direcao) {
        transform.Rotate(0,0,Time.deltaTime*direcao*-30,Space.World);
    }
    public void atirar_frontal (float tempo) {
       
        if(!atirar_normal&&vida>0){
            GameObject temp = Instantiate(projetil);
            temp.transform.position = local_intancia.transform.position;
            temp.transform.localRotation = transform.localRotation;
            atirar_normal = true;
            StartCoroutine(tiro1(tempo));
        }
    }
    public void atirar_lateral () {
        if(!atirar_especial&&vida>0){
            atirar_especial = true;
            GameObject temp = Instantiate(projetil);
            temp.transform.position = local_intancia2.transform.position;
            temp.transform.localEulerAngles = transform.localEulerAngles - new Vector3(0,0,90);

            temp = Instantiate(projetil);
            temp.transform.position = local_intancia2.transform.position;
            temp.transform.localEulerAngles = transform.localEulerAngles - new Vector3(0,0,105);

            temp = Instantiate(projetil);
            temp.transform.position = local_intancia2.transform.position;
            temp.transform.localEulerAngles = transform.localEulerAngles - new Vector3(0,0,75);

            temp = Instantiate(projetil);
            temp.transform.position = local_intancia3.transform.position;
            temp.transform.localEulerAngles = transform.localEulerAngles + new Vector3(0,0,90);

            temp = Instantiate(projetil);
            temp.transform.position = local_intancia3.transform.position;
            temp.transform.localEulerAngles = transform.localEulerAngles + new Vector3(0,0,105);

            temp = Instantiate(projetil);
            temp.transform.position = local_intancia3.transform.position;
            temp.transform.localEulerAngles = transform.localEulerAngles + new Vector3(0,0,75);
            StartCoroutine(tiro2());
        }

    }
    public void morrer () {
        if(vida<=0){
            tempo_morrer +=Time.deltaTime;
            if(tempo_morrer>2){
                Destroy(gameObject);
            }
        }
    }
    public void situacao_barco () {
        if(vida<=0){vida=0;}
        if(render==null){render=GetComponent<SpriteRenderer>();}
        if(vida>60){render.sprite=estados_barco[0];}
        else if(vida<=60&&vida>30){render.sprite=estados_barco[1];}
        else if(vida<=30&&vida>0){render.sprite=estados_barco[2];}
        else{render.sprite=estados_barco[3];}
    }
    IEnumerator tiro1(float tempo){
        
        yield return new WaitForSeconds(tempo);
        atirar_normal = false;
    }
    IEnumerator tiro2(){
        
        yield return new WaitForSeconds(3f);
        atirar_especial = false;
    }
}
