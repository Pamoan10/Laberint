using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrMaya : MonoBehaviour
{
    //Aquest es el script que porta el Player

    [SerializeField] float velocitat = 1f;
    [SerializeField] Animator animator; //Element necessari per crear les animacions
    [SerializeField] int maxSalut = 10; //Declaro la variable de la salut màxima i de l'actual (es veuran a la barra de vida)
    [SerializeField] int actualSalut;
    [SerializeField] ScrVida barraSalut;
    [SerializeField] GameObject tapa; //Em permet controlar si vull que es mostri la tapa que hi ha al mapa o no, ja que sense la tapa, al 
    [SerializeField] GameObject pantallaLooser; //Em permet controlar quan vull que apareixi la pantalla LOOSER
    //public int valorPokeball = 2; //Puntuació que sumarà cada pokeball

    Vector2 moviment;

    //Vull definir un objecte del tipus Rigidbody anomenat rb (variable), val 0. Per accedir al component RigidBody:
    Rigidbody2D rb;
    ScrPokeball scrP;
    AudioSource a; //per accedir a l'audio

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Ara el rb apunta al component rigidBody del player
        a = GetComponent<AudioSource>();
        actualSalut = maxSalut; //Quan comença, la salut està al màxim
        barraSalut.salutMax(maxSalut); //Accedeixo salut màxima de la barra de vida i li passo la salut màxima que jo he declarat
    }

    void Update() //Controla el moviment del personatge
    {
        moviment.x = Input.GetAxisRaw("Horizontal");
        moviment.y = Input.GetAxisRaw("Vertical");

        if (moviment != Vector2.zero)
        {
            animator.SetFloat("Horizontal", moviment.x);
            animator.SetFloat("Vertical", moviment.y);
        }

        animator.SetFloat("Velocitat", moviment.sqrMagnitude);
        
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moviment * velocitat * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D (Collider2D collision) //Quan entri en contacte amb un Gameobject que tingui el tag de "pokeball" o "enemic"
    {
        if (collision.CompareTag("Pokeball")) //Sumarà els punts, restarà a les pokeballs restants i destruirà la pokeball
        {
            AudioSource audioPokeball; //Defineixo la variable per acedir a l'audio de la pokeball

            audioPokeball = collision.GetComponent<AudioSource>();
            AudioSource.PlayClipAtPoint(audioPokeball.clip, Camera.main.transform.position);

            scrP = collision.GetComponent<ScrPokeball>();
            ScrPokeball.punts += scrP.valorPokeball;
            Destroy(collision.gameObject);
            ScrPokeball.pokeballs++;
            ScrPokeball.pokeballsTotal--;
        }
        if (collision.CompareTag("Tapa")) //Al primer nivell farà que una imatge que tapa al personatge a l'inici, deixi de ser visible
        {
            tapa.SetActive(false);
        }
    }

    public void Dany(int dany)
    {
        actualSalut -= dany; //Declaro que el dany que fan els enemics al col·lisionar és de 1
        barraSalut.Salut(actualSalut); //Accedeixo a la salut de la barra de salut i li passo la salut actual
        if(actualSalut <= 0) //Quan la salut actual sigui igual o més petita que 0, es farà activa la pantalla looser i es pausarà el joc
        {
            pantallaLooser.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
