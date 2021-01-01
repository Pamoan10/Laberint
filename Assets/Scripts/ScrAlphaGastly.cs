using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrAlphaGastly : MonoBehaviour
{
    [SerializeField] float alphaGastly = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ScrPokeball.pokeballsTotal == 0)
        {
            if (alphaGastly >= 0)
            {
                alphaGastly -= .01f;
            }
            
        }
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alphaGastly);

        if(alphaGastly <= 0)
        {
            Destroy(gameObject);
        }
    }
}
