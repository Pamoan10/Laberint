using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPokeball : MonoBehaviour
{
    // Start is called before the first frame update
    public int valorPokeball = 2;
    
    void Awake()
    {
        ScrControlGame.pokeballs++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
