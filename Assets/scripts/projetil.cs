using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projetil : MonoBehaviour
{
    public float tempo;
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
}
