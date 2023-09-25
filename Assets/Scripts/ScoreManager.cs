using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text puntajeText;
    public Text mensajeGanador;
    private int Soles_para_el_pollo = 0;
    public int monedasTotales;
    private int monedasRecogidas = 0;
    private void Start()
    {
        ActualizarTextoPuntaje();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Moneda")
        {
            AumentarPuntaje(5);
            monedasRecogidas++;
            if (monedasRecogidas >= monedasTotales)
            {
                MostrarMensajeGanador();
            }
            Destroy(other.gameObject);
        }
    }

    public void AumentarPuntaje(int cantidad)
    {
        Soles_para_el_pollo += cantidad;
        ActualizarTextoPuntaje();
    }

    private void ActualizarTextoPuntaje()
    {
        if (puntajeText != null)
        {
            puntajeText.text = "Soles para el pollo: " + Soles_para_el_pollo.ToString();
        }
    }
    private void MostrarMensajeGanador()
    {
        if (mensajeGanador != null)
        {
            mensajeGanador.text = "¡Ganaste!";
        }
    }
}
