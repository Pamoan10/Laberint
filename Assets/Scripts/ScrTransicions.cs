using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class ScrTransicions : MonoBehaviour
{
    //Entre cada nivell hi ha una fosa en negre, en aquest script és on la programo

    [SerializeField] Animator transicio;
    [SerializeField] float tempsTransicio = 1f;
   
    void Update()
    {
        ControlEntradaUsuari();
    }
    void ControlEntradaUsuari()
    {
        Scene escena = SceneManager.GetActiveScene(); //Vull que em detecti l'escena actual
        string escenaActual = escena.name; //Anomeno a l'escena actual com "escenaActual"
        if (escenaActual == "Intro" || escenaActual == "Intro 2") //Si l'escena actual és la de Intro o Intro 2, vull poder canviar d'escena amb "Enter"
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

}
