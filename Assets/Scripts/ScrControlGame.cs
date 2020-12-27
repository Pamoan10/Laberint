using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class ScrControlGame : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField]
    Animator transicio;
    [SerializeField]
    float tempsTransicio = 1f;
    [SerializeField]
    float tempsEspera = 38f;
    void Start()
    {
        StartCoroutine(esperaIntro());
    }

    // Update is called once per frame
    void Update()
    {
        ControlEntradaUsuari();
    }
    void ControlEntradaUsuari()
    {
        if (Input.GetKeyDown(KeyCode.Return)) CarregarNivell(); //per passar de la intro al menú
        if (Input.GetKeyDown(KeyCode.J)) Nivell1();
        //if (Input.GetKeyDown(KeyCode.C))
        if (Input.GetKeyDown(KeyCode.W)) Web();
        if (Input.GetKeyDown(KeyCode.S)) Sortir();
        
    }
    public void CarregarNivell()
    {
        StartCoroutine(CarregaNivell(SceneManager.GetActiveScene().buildIndex + 1)); //Quan es premi la tecla Enter, passarà al següent nivell
    }
    IEnumerator CarregaNivell(int levelIndex) //no vull que canvii d'escena directament, per això creo que Coroutine que permetrà veure la fosa en negre que he creat
    {
        transicio.SetTrigger("Start");
        yield return new WaitForSeconds(tempsTransicio);
        SceneManager.LoadScene(levelIndex);
    }
    IEnumerator esperaIntro()
    {
        yield return new WaitForSeconds(tempsEspera);
        SceneManager.LoadScene(1);
        
    }
    public void Nivell1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //em permet accedir al nivell 1 mitjançant el botó del menú
    }
    public void Controls()
    {

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
