using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class jogo : MonoBehaviour
{
    public GameObject [] locais_spawn;
    public static bool gameOver;
    public GameObject menu_fim;
    // Start is called before the first frame update
    void Start()
    {
        gameOver=false;
    }

    // Update is called once per frame
    void Update()
    {
        menu_fim.SetActive(gameOver);
    }
    public void menu_principal () {
        SceneManager.LoadScene("menu");
        
    }
    public void jogar_novamente () {
        SceneManager.LoadScene("jogo");
        
    }
}
