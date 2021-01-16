using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrEnemics : MonoBehaviour
{
    /*Script que tenen els enemics per controlar el dany que fan al player. Hi ha enemics amb trigger i altres amb collider, per això ho faig
    d'ambdues formes*/

    [SerializeField] int danyPokemon = 1; //Declaro la variable que controla el dany que faran els enemics
    AudioSource audioPokemon; //per accedir a l'audio

    void Start()
    {
        audioPokemon = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision) //Quan un objecte amb el tag "player" col·lisioni amb l'enemic, el player rebrà dany
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<ScrMaya>().Dany(danyPokemon);
            audioPokemon.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<ScrMaya>().Dany(danyPokemon);
            audioPokemon.Play();
        }
    }

}
