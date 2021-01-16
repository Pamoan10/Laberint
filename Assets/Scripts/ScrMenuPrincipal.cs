using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScrMenuPrincipal : MonoBehaviour
{
    //Script que pertany i controla el menú principal

    [SerializeField] GameObject pantallaControls; //Declaro una variable pública que serà la UI del botó de controls del menú
    [SerializeField] bool mostraPantalla = false; //Aquesta variable controlara si es mostra la UI de controls o no
    void Start()
    {
        ScrPokeball.pokeballsTotal = 0; //Afegeixo que cada cop que s'inicii el menú principal, les variables es resetegin
        ScrPokeball.pokeballs = 0;
        ScrPokeball.punts = 0;
    }

    void Update()
    {
        Menu();
    }
    void Menu()
    {
        if (Input.GetKeyDown(KeyCode.J)) Nivell1(); //Associo cada botó amb una acció i una tecla del teclat
        if (Input.GetKeyDown(KeyCode.C)) Controls();
        if (Input.GetKeyDown(KeyCode.W)) Web();
        if (Input.GetKeyDown(KeyCode.S)) Sortir();
    }
    public void Nivell1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Em permet accedir al nivell 1 mitjançant el botó del menú
    }
    public void Controls()
    {
        pantallaControls.SetActive(true); //Mostra la pantalla de controls
        mostraPantalla = true;
    }
    public void surtControls()
    {
        pantallaControls.SetActive(false);
        mostraPantalla = false;
    }
    public void Web()
    {
        Application.OpenURL("https://twitter.com/Pamoan10"); //Permet accedir a un web 
    }
    public void Sortir()
    {
        Application.Quit(); //Permet sortir del joc
    }
}
