using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Personaje : MonoBehaviour
{
    [SerializeField] private float velocidad = 5f; // Ajusta la velocidad desde el Inspector

    private Rigidbody2D rig;
    private Vector2 movimiento;

    private void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Leer input cada frame
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Guardar vector de movimiento
        movimiento = new Vector2(horizontal, vertical) * velocidad;

    }

    private void FixedUpdate()
    {
        // Aplicar velocidad al Rigidbody2D
        rig.linearVelocity = movimiento;
    }
}

