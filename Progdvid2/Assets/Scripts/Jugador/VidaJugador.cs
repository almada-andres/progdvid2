using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public int vidaActual = 3;

    // M�todo para recibir da�o
    public void RecibirDano(int cantidadDano)
    {
        // Restar la cantidad de da�o a la vida actual
        vidaActual -= cantidadDano;

        // Mostrar un mensaje indicando la cantidad de da�o recibido
        Debug.Log("El jugador ha recibido " + cantidadDano + " puntos de da�o.");

        // Comprobar si la vida llega a 0 o menos
        if (vidaActual <= 0)
        {
            // L�gica para manejar la derrota o muerte del jugador
            Debug.Log("Jugador ha muerto.");
        }
    }
}
