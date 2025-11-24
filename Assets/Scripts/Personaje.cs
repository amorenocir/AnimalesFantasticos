using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Personaje : MonoBehaviour
{
    [SerializeField] private float velocidad = 5f; // Ajusta la velocidad desde el Inspector

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
        // Leer input cada frame
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Guardar vector de movimiento
        movimiento = new Vector2(horizontal, vertical) * velocidad;

        if (horizontal > 0)
        {
            spritePersonaje.flipX = false;
        }
        else if (horizontal < 0)
        {
            spritePersonaje.flipX = true;
        }
    }

    private void FixedUpdate()
    {
        // Aplicar velocidad al Rigidbody2D
        rig.linearVelocity = movimiento;
        anim.SetFloat("Anda", Mathf.Abs(rig.linearVelocity.magnitude));

        
    }
}

