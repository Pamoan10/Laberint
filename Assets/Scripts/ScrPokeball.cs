using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPokeball : MonoBehaviour
{
    //Aquest script pertany als pickups

    public int valorPokeball = 2; //Declaro el valor del pickup
    public static int punts = 0; //Puntuació
    public static int pokeballs = 0; //Pickups recollits
    public static int pokeballsTotal = 0; //Pickups restants

    void Awake()
    {
        pokeballsTotal++; //Compta tots els pickups del nivell
    }
    

}
