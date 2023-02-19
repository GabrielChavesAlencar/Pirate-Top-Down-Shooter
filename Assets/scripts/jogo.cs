using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class jogo : MonoBehaviour
{
    public GameObject [] locais_spawn;
    public static bool gameOver;
    public static bool morte_player;
    public GameObject menu_fim;

    public GameObject Inimigo_Chaser;
    public GameObject Inimigo_Shoter;
    public bool inimigo_invocado;
    public static int Score;
    public Text tempo_texto;
    public Text pont_texto;
    public Text fim_texto;
    public Text pontuacao_fim;
    public float tempo;
    // Start is called before the first frame update
    void Start()
    {
        gameOver=false;
        tempo =menu.tempo_jogo;
        Score = 0;
        morte_player = false;
    }

    // Update is called once per frame
    void Update()
    {
        float primeiro_num =(int)tempo/60;
        if(tempo<=0){
            tempo=0;
            gameOver = true;
            fim_texto.text= "Fase Concluida com sucesso";
            pontuacao_fim.text = "Pontuação: " + Score;
        }
        if(morte_player){
             fim_texto.text= "GAME OVER";
             pontuacao_fim.text = "";
        }
        if(!gameOver){tempo-=Time.deltaTime;}
        pont_texto.text = "Pontuação: " + Score;
        tempo_texto.text = "Tempo: " + primeiro_num+ ":"+(int)(tempo-primeiro_num*60);
        menu_fim.SetActive(gameOver);
        if(!inimigo_invocado&&!jogo.gameOver){ inimigo_invocado = true;StartCoroutine(Spanwnador(menu.tempo_spawn));}
    }
    public void menu_principal () {
        SceneManager.LoadScene("menu");
        
    }
    public void jogar_novamente () {
        SceneManager.LoadScene("jogo");
        
    }
    IEnumerator Spanwnador(float tempo){
        GameObject temp;
        int rand = Random.Range(0,2);
        int num_local = Random.Range(0,locais_spawn.Length);
        if(rand==0){temp = Instantiate(Inimigo_Chaser);}
        else{temp = Instantiate(Inimigo_Shoter);}
        temp.transform.position = locais_spawn[num_local].transform.position;
        yield return new WaitForSeconds(tempo); 
        inimigo_invocado = false;   
    }
}
