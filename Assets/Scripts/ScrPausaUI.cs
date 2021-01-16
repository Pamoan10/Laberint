using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScrPausaUI : MonoBehaviour
{
    /// <summary>
    /// ------------------------------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script que pertany al menú de pausa
    /// AUTORA: Paula Moreta
    /// DATA:   02/01/2021
    /// VERSIÓ: 2.0
    /// CONTROL DE VERSIONS
    ///         1.0: primera versió. Activació del canvas amb la lletra P i pausa del joc
    ///         2.0: segona versió.  Milloro la funcionalitat i estètica
    /// -------------------------------------------------------------------------------------------------------
    /// </summary>

    [SerializeField] GameObject pantallaPausa; //Declaro aquesta variable que em permetrà accedir desde unity al gameobject de la UI de pausa
    [SerializeField] bool pausat = false; //Em permetrà controlar la visibilitat del menú de pausa
    void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) //Amb la tecla P es pausa i es despausa el joc
        {
            if (pausat) Reprendre();
            else PausaJoc();
        }
    }
    void PausaJoc()
    {
        pantallaPausa.SetActive(true); //Mostra la UI
        pausat = true;
        Time.timeScale = 0; //Pausa el joc
    }
    public void Reprendre()
    {
        pantallaPausa.SetActive(false); //Amaga la UI
        pausat = false;
        Time.timeScale = 1; //Repren el joc
    }
    public void Menu()
    {
        Time.timeScale = 1; //Carrega el menú principal, és a dir l'escena 2
        SceneManager.LoadScene(2);
    }
    public void Sortir()
    {
        Application.Quit(); //Surt del joc
    }
}
