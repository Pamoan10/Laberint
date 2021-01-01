using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrUI : MonoBehaviour
{
    [SerializeField] Text puntuacio, temps;
    
    float crono = 0;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        temps.text = crono.ToString("0.0");
        puntuacio.text = ScrPokeball.punts.ToString();
        crono += Time.deltaTime;
    }
  
}
