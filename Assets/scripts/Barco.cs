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


    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void andar_frente () {
       transform.Translate(0,Time.deltaTime*1,0);
    }

    public void rotacionar ( float direcao) {
        transform.Rotate(0,0,Time.deltaTime*direcao*-30,Space.World);
    }
    public void atirar_frontal () {
        if(!atirar_normal){
            GameObject temp = Instantiate(projetil);
            temp.transform.position = local_intancia.transform.position;
            temp.transform.localRotation = transform.localRotation;
            atirar_normal = true;
            StartCoroutine(tiro1());
        }
    }
    public void atirar_lateral () {
        if(!atirar_especial){
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
    public void situacao_barco () {
        if(render==null){render=GetComponent<SpriteRenderer>();}
        if(vida>60){render.sprite=estados_barco[0];}
        else if(vida<=60&&vida>30){render.sprite=estados_barco[1];}
        else if(vida<=30&&vida>0){render.sprite=estados_barco[2];}
        else{render.sprite=estados_barco[3];}
    }
    IEnumerator tiro1(){
        
        yield return new WaitForSeconds(1f);
        atirar_normal = false;
    }
    IEnumerator tiro2(){
        
        yield return new WaitForSeconds(3f);
        atirar_especial = false;
    }
}
