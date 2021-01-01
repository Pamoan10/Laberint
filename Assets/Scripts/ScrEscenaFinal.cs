using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrEscenaFinal : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject sortir;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) sortir.GetComponent<ScrPausaUI>().Sortir();
        if (Input.GetKeyDown(KeyCode.Return)) sortir.GetComponent<ScrPausaUI>().Menu(); 
    }
}
