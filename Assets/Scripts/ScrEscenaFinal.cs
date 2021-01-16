using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrEscenaFinal : MonoBehaviour
{
    /// <summary>
    /// ------------------------------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script de l'escena final
    /// AUTORA: Paula Moreta
    /// DATA:   06/01/2021
    /// VERSIÓ: 1.0
    /// CONTROL DE VERSIONS
    ///         1.0: primera versió. Creo la UI i aprofito els botons del menú de pausa
    /// -------------------------------------------------------------------------------------------------------
    /// </summary>

    [SerializeField] GameObject sortir; //Declaro aquest gameobject d'on aprofitaré la programació del menú de pausa pels botons d'aquesta escena
    void Update()
    {
        //Accedeixo al script de pausa on tinc la programació dels botons per no haver-ho de programar de nou
        if (Input.GetKeyDown(KeyCode.Escape)) sortir.GetComponent<ScrPausaUI>().Sortir();  
        if (Input.GetKeyDown(KeyCode.Return)) sortir.GetComponent<ScrPausaUI>().Menu(); 
    }
}
