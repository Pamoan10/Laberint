using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScrPausaUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject pantallaPausa; //declaro aquesta variable que em permetrà accedir desde unity al gameobject de la UI de pausa
    [SerializeField] bool pausat = false;
    void Start()
    {
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (pausat) Reprendre();
            else PausaJoc();
        }
    }
    void PausaJoc()
    {
        pantallaPausa.SetActive(true); //mostra la UI
        pausat = true;
        Time.timeScale = 0; //pausa el joc
    }
    public void Reprendre()
    {
        pantallaPausa.SetActive(false); //amaga la UI
        pausat = false;
        Time.timeScale = 1; //repren el joc
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void Sortir()
    {
        Application.Quit();
    }
}
