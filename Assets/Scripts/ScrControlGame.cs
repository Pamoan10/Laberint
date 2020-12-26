using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class ScrControlGame : MonoBehaviour
{
    // Start is called before the first frame update
    string[] escenes = { "Intro", "Nivell 1", "Nivell 2", "Nivell 3" }; // creo un array per organitzar els diferents nivells
    static int level = 0; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ControlEntradaUsuari();
    }
    void ControlEntradaUsuari()
    {
        if (Input.GetKeyDown(KeyCode.J)) Nivell1();
        //if (Input.GetKeyDown(KeyCode.C))
        if (Input.GetKeyDown(KeyCode.W)) Web();
        if (Input.GetKeyDown(KeyCode.S)) Sortir();
    }
    public void Nivell1()
    {
        SceneManager.LoadScene(escenes[level + 1]); //em permet accedir al nivell 1 mitjançant el botó del menú
    }
    public void Controls()
    {

    }
    public void Web()
    {
        Application.OpenURL("https://twitter.com/Pamoan10");
    }
    public void Sortir()
    {
        Application.Quit();
    }
}
