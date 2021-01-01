using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScrMenuPrincipal : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject pantallaControls; //declaro una variable pública que serà la UI del botó de controls del menú
    [SerializeField] bool mostraPantalla = false; //aquesta variable controlara si es mostra la UI de controls o no
    void Start()
    {
        ScrPokeball.pokeballsTotal = 0;
        ScrPokeball.pokeballs = 0;
        ScrPokeball.punts = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Menu();
    }
    void Menu()
    {
        if (Input.GetKeyDown(KeyCode.J)) Nivell1();
        if (Input.GetKeyDown(KeyCode.C)) Controls();
        if (Input.GetKeyDown(KeyCode.W)) Web();
        if (Input.GetKeyDown(KeyCode.S)) Sortir();
    }
    public void Nivell1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //em permet accedir al nivell 1 mitjançant el botó del menú
    }
    public void Controls()
    {
        pantallaControls.SetActive(true);
        mostraPantalla = true;
    }
    public void surtControls()
    {
        pantallaControls.SetActive(false);
        mostraPantalla = false;
    }
    public void Web()
    {
        Application.OpenURL("https://twitter.com/Pamoan10"); //permet accedir a un web 
    }
    public void Sortir()
    {
        Application.Quit(); //permet sortir del joc
    }
}
