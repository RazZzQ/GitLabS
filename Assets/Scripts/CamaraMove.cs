using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMove : MonoBehaviour
{
    public Transform jugador;
    public Vector3 posicionInicial = new Vector3(337f, -174f, -266f);

    void Start()
    {
        // Establecer la posici�n inicial de la c�mara
        transform.position = new Vector3(posicionInicial.x, transform.position.y, transform.position.z);
    }

    void Update()
    {
        if (jugador != null)
        {
            // Obtener la posici�n actual de la c�mara
            Vector3 nuevaPosicion = transform.position;
            // Actualizar solo la coordenada X con la posici�n del jugador
            nuevaPosicion.x = jugador.position.x;
            // Establecer la nueva posici�n de la c�mara
            transform.position = nuevaPosicion;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Cambia la proyecci�n de la c�mara a perspectiva 3D
            Camera.main.orthographic = false;

            Camera.main.fieldOfView = 10f;
        }
    }
}
