using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScrEsperaInicial : MonoBehaviour
{
    /// <summary>
    /// ------------------------------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script que controla l'espera inicial quan surt la cinemàtica per canviar al següent nivell de forma automàtica
    /// AUTORA: Paula Moreta
    /// DATA:   30/12/2020
    /// VERSIÓ: 1.0
    /// CONTROL DE VERSIONS
    ///         1.0: primera versió. Creo el temps d'espera perquè carregui la segona escena
    /// -------------------------------------------------------------------------------------------------------
    /// </summary>

    [SerializeField] float tempsEspera = 38f; //Declaro el temps d'espera per activar la escena num 1, són els segons que dura el video de la intro
    
    void Start()
    {
        StartCoroutine(esperaIntro()); //Inicio el temps d'espera per a canviar d'escena
    }

    IEnumerator esperaIntro()
    {
        Scene escena = SceneManager.GetActiveScene(); //Vull que em detecti l'escena actual, la que està activa
        string escenaActual = escena.name; //Anomeno a l'escena actual com "escenaActual"
        if (escenaActual == "Intro")
        {
            yield return new WaitForSeconds(tempsEspera);
            SceneManager.LoadScene(1); //Quan passin 38 segons, que és el temps d'espera, vull que em carregui l'escena 1 
        }

    }
}
