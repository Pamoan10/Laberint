using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrUI : MonoBehaviour
{
    //Aquest es el script de la UI on s'imprimeix el cronòmetre i els punts

    [SerializeField] Text puntuacio, temps;
    
    float crono = 0;
    
    void Update()
    {
        temps.text = crono.ToString("0.0");
        puntuacio.text = ScrPokeball.punts.ToString();
        crono += Time.deltaTime;
    }
  
}
