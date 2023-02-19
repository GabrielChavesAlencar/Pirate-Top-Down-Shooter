using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    public static float tempo_jogo;
    public static float tempo_spawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void iniciar_jogo () {
        SceneManager.LoadScene("jogo");
        
    }
}
