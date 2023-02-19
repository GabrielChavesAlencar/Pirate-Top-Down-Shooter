using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculo : MonoBehaviour
{
    public GameObject explosao;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="Player"){
            other.gameObject.GetComponent<Player>().vida-=10;
            GameObject temp = Instantiate(explosao);
            temp.transform.position= transform.position;
            Destroy(gameObject);
        }
        
    }
}
