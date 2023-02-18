using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil : MonoBehaviour
{
    public float tempo;
    public GameObject explosao;
    public bool inimigo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo+=Time.deltaTime;
        transform.Translate(0,Time.deltaTime*3,0);
        if(tempo>3){
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="inimigo"&&!inimigo){
            GameObject temp = Instantiate(explosao);
            temp.transform.position= transform.position;
            Destroy(gameObject);
            other.gameObject.GetComponent<Inimigo>().vida-=20;
        }
        if(other.gameObject.tag=="Player"&&inimigo){
            GameObject temp = Instantiate(explosao);
            temp.transform.position= transform.position;
            Destroy(gameObject);
            other.gameObject.GetComponent<Player>().vida-=20;
        }
    }
}
