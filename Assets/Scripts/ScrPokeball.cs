using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPokeball : MonoBehaviour
{
    /// <summary>
    /// ------------------------------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script que pertany als pickups
    /// AUTORA: Paula Moreta
    /// DATA:   29/12/2020
    /// VERSIÓ: 1.0
    /// CONTROL DE VERSIONS
    ///         1.0: primera versió. Declaro els valors
    /// -------------------------------------------------------------------------------------------------------
    /// </summary>

    public int valorPokeball = 2; //Declaro el valor del pickup
    public static int punts = 0; //Puntuació
    public static int pokeballs = 0; //Pickups recollits
    public static int pokeballsTotal = 0; //Pickups restants

    void Awake()
    {
        pokeballsTotal++; //Compta tots els pickups del nivell
    }
    

}
