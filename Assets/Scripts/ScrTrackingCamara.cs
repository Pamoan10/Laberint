﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrTrackingCamara : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform tracking; //afegeixo aquesta variable que em servirà per decidir què vull que la càmera segueixi
     
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(tracking.position.x, -0.9f, 0.9f), //delimito els límits de la càmera respecte el mapa
            Mathf.Clamp(tracking.position.y, -1.2f, 1.4f), 
            transform.position.z); //la càmera seguirà en els diferents eixos al personatge
    }
}