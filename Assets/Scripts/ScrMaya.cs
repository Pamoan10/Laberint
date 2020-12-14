using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrMaya : MonoBehaviour
{
    [SerializeField]
    float forsa = 3;
    float x, y; //variables per guardar lectura dels cursors de forma global

    //Vull definir un objecte del tipus Rigidbody anomenat rb (variable), val 0. Per accedir al component RigidBody:
    Rigidbody2D rb;
    //ScrPickup scrP;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //ara rb apunta al component rigidBody del player AIXÒ ÉS BÀSIC
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal"); //llegir moviment horizontal
        y = Input.GetAxis("Vertical"); //llegir moviment vertical
    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(x * forsa, y * forsa));
    }
}
