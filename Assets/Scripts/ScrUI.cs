using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrUI : MonoBehaviour
{
    /// <summary>
    /// ------------------------------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script que controla els valors de la UI
    /// AUTORA: Paula Moreta
    /// DATA:   31/12/2020
    /// VERSIÓ: 1.0
    /// CONTROL DE VERSIONS
    ///         1.0: primera versió. Declarar el temps i la puntuació
    /// -------------------------------------------------------------------------------------------------------
    /// </summary>

    [SerializeField] Text puntuacio, temps;
    
    float crono = 0;
    
    void Update()
    {
        temps.text = crono.ToString("0.0");
        puntuacio.text = ScrPokeball.punts.ToString();
        crono += Time.deltaTime;
    }
  
}
