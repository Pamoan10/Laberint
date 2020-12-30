using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScrDetectaSortida : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject pantallaWin;
    [SerializeField] Text recollides, puntuacio;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        float escala = 0;
        if (collision.CompareTag("Sortida") && GetComponentInParent<Rigidbody2D>().velocity.magnitude < 3)
        {
            GetComponentInParent<Rigidbody2D>().velocity = new Vector2(0, 0);
            transform.parent.position = Vector3.Lerp(transform.parent.position, collision.transform.position, .05f);

            escala = transform.parent.localScale.x;
            if (escala > 0.1)
            {
                escala -= 0.01f;
                transform.parent.localScale = new Vector3(escala, escala, 1);
            }
            if (escala < 0.1)
            {
                pantallaWin.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
    void Update()
    {
        recollides.text = ("RECOLLIDES: " + ScrControlGame.pokeballs);
        puntuacio.text = ("PUNTUACIÓ: " + ScrControlGame.punts);
        if (pantallaWin.activeSelf) SeguentNivell();
    }
    void SeguentNivell()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Time.timeScale = 1;
        }
       
    }
}
