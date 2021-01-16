using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrEnemics : MonoBehaviour
{
    /// <summary>
    /// ------------------------------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script que tenen els enemics (amb trigger i collider) per controlar el dany que fan al player.
    /// AUTORA: Paula Moreta
    /// DATA:   01/01/2021
    /// VERSIÓ: 3.0
    /// CONTROL DE VERSIONS
    ///         1.0: primera versió. Detecta els que tenen trigger i resta el dany
    ///         2.0: segona versió.  Detecta els que tenen collider i resta el dany
    ///         3.0: tercera versió. Implementació del so
    /// -------------------------------------------------------------------------------------------------------
    /// </summary>
    
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
