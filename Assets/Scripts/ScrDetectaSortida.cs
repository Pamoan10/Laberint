using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScrDetectaSortida : MonoBehaviour
{
    //Pertany al trigger que s'encarrega de detectar la sortida i posar visible la pantalla Win per poder passar al següent nivell

    [SerializeField] GameObject pantallaWin; //Declaro la pantalla de victòria i els elements que sortiran en ella
    [SerializeField] Text recollides, puntuacio;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        float escala = 0; //Declaro l'escala del Player
        if (collision.CompareTag("Sortida") && GetComponentInParent<Rigidbody2D>().velocity.magnitude < 3)
        {
            GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, 0);
            transform.parent.position = Vector3.Lerp(transform.parent.position, collision.transform.position, .05f);

            escala = transform.parent.localScale.x; //Quan estiguis dins del trigger de sortida, et començaràs a fer petit
            if (escala > 0.1)
            {
                escala -= 0.01f;
                transform.parent.localScale = new Vector3(escala, escala, 1);
            }
            if (escala < 0.1) //Quan ja siguis petit, es farà visible la pantalla de victòria i es pausarà el joc
            {
                pantallaWin.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
    void Update()
    {
        recollides.text = ("RECOLLIDES: " + ScrPokeball.pokeballs); //Indico el que s'imprimirà per pantalla
        puntuacio.text = ("PUNTUACIÓ: " + ScrPokeball.punts);
        if (pantallaWin.activeSelf) SeguentNivell();
    }
    void SeguentNivell() //Quan premis Enter i la pantalla de victòria estigui visible, es carregarà la següent escena
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 1;
        }
       
    }
}
