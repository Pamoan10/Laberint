using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrVida : MonoBehaviour
{
    //Script que s'encarrega de controlar el slider de la vida
    
    [SerializeField] Slider slider; //Declaro el slider que després vincularé a Unity
    [SerializeField] Gradient degradat; //Vull que el color de la vida canvii segons quanta té, per això crearé un degradat
    [SerializeField] Image barra;
    
    public void salutMax (int salut) //Marco la salut màxima i la mínima
    {
        slider.maxValue = salut;
        slider.value = salut;

        barra.color = degradat.Evaluate(1f); //Salut màxima el color serà verd
    }
    public void Salut (int salut) //Faig la funció pública per poder accedir des de un altre script
    {
        slider.value = salut; //Associo el valor del slider amb el nom de "salut"
        barra.color = degradat.Evaluate(slider.normalizedValue);
    }
  
}
