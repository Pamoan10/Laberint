using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrMaya : MonoBehaviour
{
    [SerializeField] float velocitat = 1f;
    [SerializeField] Animator animator; //permet
    [SerializeField] int maxSalut = 10; //declaro la variable de la salut màxima i de l'actual
    [SerializeField] int actualSalut;
    [SerializeField] ScrEnemicsiVida barraSalut;

    Vector2 moviment;

    //Vull definir un objecte del tipus Rigidbody anomenat rb (variable), val 0. Per accedir al component RigidBody:
    Rigidbody2D rb;
    ScrPokeball scrP;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //ara rb apunta al component rigidBody del player
        actualSalut = maxSalut; //quan comença la salut està al màxim
        barraSalut.salutMax(maxSalut); //accedeixo a ScrEnemics i vida i li passo la salut màxima
        
    }

    // Update is called once per frame
    void Update()
    {
        moviment.x = Input.GetAxisRaw("Horizontal");
        moviment.y = Input.GetAxisRaw("Vertical");

        if (moviment != Vector2.zero)
        {
            animator.SetFloat("Horizontal", moviment.x);
            animator.SetFloat("Vertical", moviment.y);
        }

        animator.SetFloat("Velocitat", moviment.sqrMagnitude);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Dany(1);
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moviment * velocitat * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision) //Quan entri en contacte amb un Gameobject que tingui el tag de "pokeball" o "enemic"
    {
        if (collision.CompareTag("Pokeball"))
        {
            scrP = collision.GetComponent<ScrPokeball>();
            ScrControlGame.punts += scrP.valorPokeball;
            Destroy(collision.gameObject);
            ScrControlGame.pokeballs--;
        }
        if (collision.CompareTag("Enemic"))
        {
            Dany(1);
        }
    }
    
    void Dany(int dany)
    {
        actualSalut -= dany; //declaro que el dany que fan els enemics al col·lisionar és de 1
        barraSalut.Salut(actualSalut); //accedeixo a ScrEnemicsiVida i li passo la salut actual
    }
}
