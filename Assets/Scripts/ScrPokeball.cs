using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPokeball : MonoBehaviour
{
    // Start is called before the first frame update
    public int valorPokeball = 2;
    public static int punts = 0; //puntuació
    public static int pokeballs = 0; //pokeballs recollides
    public static int pokeballsTotal = 0; //pokeballs restant

    void Awake()
    {
        pokeballsTotal++;
    }
    

}
