using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrTrackingCamara : MonoBehaviour
{
    /// <summary>
    /// ------------------------------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script que pertany a la càmera i em permet limitar i controlar el seu moviment
    /// AUTORA: Paula Moreta
    /// DATA:   31/12/2020
    /// VERSIÓ: 2.0
    /// CONTROL DE VERSIONS
    ///         1.0: primera versió. Faig que la càmera segueixi al personatge mitjançant codi
    ///         2.0: segona versió.  Limito el moviment de la càmera
    /// -------------------------------------------------------------------------------------------------------
    /// </summary>

    [SerializeField] Transform tracking; //Afegeixo aquesta variable que em servirà per decidir què vull que la càmera segueixi
    float tamany = 1.6f;
   
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(tracking.position.x, -1.35f, 1.35f), //delimito els límits de la càmera respecte el mapa
            Mathf.Clamp(tracking.position.y, -1.35f, 1.35f), 
            transform.position.z); //la càmera seguirà en els diferents eixos al personatge
        Camera.main.orthographicSize = tamany;
    }
}
