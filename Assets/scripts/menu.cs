using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class menu : MonoBehaviour
{
    public static float tempo_jogo;
    public static float tempo_spawn;
    public Slider controle_tempo;
    public Slider controle_spawn;

    public Text tempo_text;
    public Text spawn_text;

    public GameObject menu_principal;
    public GameObject menu_config;
    public bool ativacao_menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        menu_principal.SetActive(!ativacao_menu);
        menu_config.SetActive(ativacao_menu);
        tempo_jogo = controle_tempo.value*60;
        float primeiro_num =(int)tempo_jogo/60;
        tempo_spawn = controle_spawn.value;
        tempo_text.text = primeiro_num+ ":"+(int)(tempo_jogo-primeiro_num*60);
        spawn_text.text = controle_spawn.value+"S";
    }
    public void iniciar_jogo () {
        SceneManager.LoadScene("jogo");
        
    }
    public void trocar_menu () {
        ativacao_menu =!ativacao_menu;
    }
}
