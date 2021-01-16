using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrAlphaGastly : MonoBehaviour
{
    /// <summary>
    /// ------------------------------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script utilitzat per controlar la visibilitat del personatge que t'impedeix sortir del nivell
    /// AUTORA: Paula Moreta
    /// DATA:   29/12/2020
    /// VERSIÓ: 1.0
    /// CONTROL DE VERSIONS
    ///         1.0: primera versió. Desapareix i es destrueix
    /// -------------------------------------------------------------------------------------------------------
    /// </summary>

    [SerializeField] float alphaGastly = 1f; //Declaro la variable que controlarà la opacitat de Gastly/Haunter/Gengar (els pokémons que tanquen la sortida del nivell)
 
    void Update()
    {
        if (ScrPokeball.pokeballsTotal == 0) //Quan el nombre de pokeballs a l'escena sigui 0, començarà a desaparèixer el sprite
        {
            if (alphaGastly >= 0) //indico que si la opacitat és major a 0, vagi baixant fins que sigui 0
            {
                alphaGastly -= .01f;
            }
        }
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alphaGastly);

        if(alphaGastly <= 0) //Quan desapareix, es destrueix perquè puguis sortir
        {
            Destroy(gameObject);
        }
    }
}
