using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScrEsperaInicial : MonoBehaviour
{
    [SerializeField] float tempsEspera = 38f; //temps d'espera per activar la escena num 1, són els segons que dura el video de la intro
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(esperaIntro()); //inicio els temps d'espera per a canviar d'escena
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
