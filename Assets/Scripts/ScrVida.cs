using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrVida : MonoBehaviour
{
 
    [SerializeField] Slider slider; //declaro el slider que després vincularé a Unity
    [SerializeField] Gradient degradat; //vull que el color de la vida canvii segons quanta té, per això crearé un degradat
    [SerializeField] Image barra;
    
    public void salutMax (int salut) //marco la salut màxima i la mínima
    {
        slider.maxValue = salut;
        slider.value = salut;

        barra.color = degradat.Evaluate(1f); //salut màxima el color serà verd
    }
    public void Salut (int salut) //faig la funció pública per poder accedir des de un altre script
    {
        slider.value = salut; //associo el valor del slider amb el nom de "salut"
        barra.color = degradat.Evaluate(slider.normalizedValue);
    }
  
}
