using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public float velocidadMovimiento; // Velocidad de movimiento horizontal del enemigo
    private int direccion = 1; // 1 para moverse hacia la derecha, -1 para moverse hacia la izquierda

    private void Update()
    {
        Vector3 movimiento = Vector3.back * velocidadMovimiento * direccion * Time.deltaTime;

        transform.Translate(movimiento);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el otro objeto tiene un collider que es un trigger
        if (other.isTrigger)
        {
            direccion *= -1;
        }
    }
}
