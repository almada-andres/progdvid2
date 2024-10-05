using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public int vidaActual = 3;

    // Método para recibir daño
    public void RecibirDano(int cantidadDano)
    {
        // Restar la cantidad de daño a la vida actual
        vidaActual -= cantidadDano;

        // Mostrar un mensaje indicando la cantidad de daño recibido
        Debug.Log("El jugador ha recibido " + cantidadDano + " puntos de daño.");

        // Comprobar si la vida llega a 0 o menos
        if (vidaActual <= 0)
        {
            // Lógica para manejar la derrota o muerte del jugador
            Debug.Log("Jugador ha muerto.");
        }
    }
}
