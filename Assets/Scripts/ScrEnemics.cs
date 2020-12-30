using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrEnemics : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<ScrMaya>().Dany(1);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<ScrMaya>().Dany(1);
        }
    }

}
