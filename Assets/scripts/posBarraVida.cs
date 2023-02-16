using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posBarraVida : MonoBehaviour
{
    public GameObject barco;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = barco.transform.position+new Vector3(0,1.4f,0);
        transform.eulerAngles = new Vector3(0,0,0);

    }
}
