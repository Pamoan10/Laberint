using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class ScrControlGame : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField] Animator transicio;
    [SerializeField] float tempsTransicio = 1f;
    [SerializeField] float tempsEspera = 38f; //temps d'espera per activar la escena num 1, són els segons que dura el video de la intro

    void Start()
    {
        StartCoroutine(esperaIntro()); //inicio els temps d'espera per a canviar d'escena
    }

    // Update is called once per frame
    void Update()
    {
        ControlEntradaUsuari();
    }
    void ControlEntradaUsuari()
    {
        Scene escena = SceneManager.GetActiveScene(); //vull que em detecti l'escena actual
        string escenaActual = escena.name; //anomeno a l'escena actual com "escenaActual"
        if (escenaActual == "Intro" || escenaActual == "Intro 2") //si l'escena actual és la de Intro o Intro 2, vull poder canviar d'escena amb "Enter"
        {
            if(Input.GetKeyDown(KeyCode.Return)) CarregarNivell();
        }
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
        Scene escena = SceneManager.GetActiveScene(); //vull que em detecti l'escena actual
        string escenaActual = escena.name; //anomeno a l'escena actual com "escenaActual"
        if (escenaActual == "Intro")
        {
            yield return new WaitForSeconds(tempsEspera);
            SceneManager.LoadScene(1); //quan passin 38 segons vull que em carregui l'escena 1 
        }
        
    }
    
}
