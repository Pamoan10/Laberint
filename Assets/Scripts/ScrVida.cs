using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrVida : MonoBehaviour
{
    /// <summary>
    /// ------------------------------------------------------------------------------------------------------
    /// DESCRIPCIÓ
    ///         Script que controla el slider de la vida
    /// AUTORA: Paula Moreta
    /// DATA:   03/03/2021
    /// VERSIÓ: 2.0
    /// CONTROL DE VERSIONS
    ///         1.0: primera versió. Crear el slider i que funcioni
    ///         2.0: segona versió.  Implementar el degradat
    /// -------------------------------------------------------------------------------------------------------
    /// </summary>

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
