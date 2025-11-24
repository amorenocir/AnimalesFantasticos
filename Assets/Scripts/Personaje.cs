using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Personaje : MonoBehaviour
{
    [SerializeField] private float velocidad = 5f;

    private Rigidbody2D rig;
    private Vector2 movimiento;
    private Animator anim;
    private SpriteRenderer spritePersonaje;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponentInChildren<Animator>();
        spritePersonaje = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        Movimiento();
    }

    private void FixedUpdate()
    {
        // Aplicar velocidad al Rigidbody2D
        rig.linearVelocity = movimiento;

        // Actualizar animacion
        anim.SetFloat("Anda", Mathf.Abs(rig.linearVelocity.magnitude));
    }

    private void Movimiento()
    {
        // Leer input
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calcular vector de movimiento
        movimiento = new Vector2(horizontal, vertical) * velocidad;

        // Girar sprite segun direccion horizontal
        if (horizontal > 0)
        {
            spritePersonaje.flipX = false;
        }
        else if (horizontal < 0)
        {
            spritePersonaje.flipX = true;
        }
    }
}


