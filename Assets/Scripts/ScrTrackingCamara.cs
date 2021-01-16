using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrTrackingCamara : MonoBehaviour
{
    //Aquest script pertany a la càmera i em permet limitar i controlar el seu moviment

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
