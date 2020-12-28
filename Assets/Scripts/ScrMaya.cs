using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrMaya : MonoBehaviour
{
    [SerializeField] float velocitat = 1f;
    [SerializeField] Animator animator; //permet

    Vector2 moviment;

    //Vull definir un objecte del tipus Rigidbody anomenat rb (variable), val 0. Per accedir al component RigidBody:
    Rigidbody2D rb;
    ScrPokeball scrP;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //ara rb apunta al component rigidBody del player
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
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moviment * velocitat * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pokeball"))
        {
            scrP = collision.GetComponent<ScrPokeball>();
            ScrControlGame.punts += scrP.valorPokeball;
            Destroy(collision.gameObject);
            ScrControlGame.pokeballs--;
        }
    }
}
