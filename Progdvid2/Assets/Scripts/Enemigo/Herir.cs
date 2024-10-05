using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herir : MonoBehaviour
{
    public int dano = 1;

    // M�todo que detecta la colisi�n con otro objeto
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Verifica si el objeto con el que colisiona es el jugador
        if (collision.gameObject.CompareTag("Jugador"))
        {
            VidaJugador vidaJugador = collision.gameObject.GetComponent<VidaJugador>();

            if (vidaJugador != null)
            {
                vidaJugador.RecibirDano(dano);
            }

            DestruirEnemigo();
        }
    }

    // M�todo para destruir al enemigo
    private void DestruirEnemigo()
    {
        Destroy(gameObject);
    }
}
