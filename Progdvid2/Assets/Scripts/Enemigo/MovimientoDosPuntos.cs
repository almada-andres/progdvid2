using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDosPuntos : MonoBehaviour
{
    public float distancia = 3f; // Distancia a moverse a la izquierda y derecha
    public float velocidad = 2f; // Velocidad de movimiento

    private Vector2 puntoA; // Posición inicial menos la distancia
    private Vector2 puntoB; // Posición inicial más la distancia
    private Vector2 objetivoActual; // El punto objetivo actual

    void Start()
    {
        // Calculo de los puntos A y B basado en la posición inicial
        puntoA = new Vector2(transform.position.x - distancia, transform.position.y);
        puntoB = new Vector2(transform.position.x + distancia, transform.position.y);

        // Comenzamos moviéndonos hacia el punto B
        objetivoActual = puntoB;
    }

    void Update()
    {
        // El enemigo se mueve hacia el objetivo actual
        transform.position = Vector2.MoveTowards(transform.position, objetivoActual, velocidad * Time.deltaTime);

        // Si el enemigo llega al punto objetivo, alternamos entre A y B
        if (Vector2.Distance(transform.position, objetivoActual) < 0.1f)
        {
            objetivoActual = (objetivoActual == puntoA) ? puntoB : puntoA;
        }
    }
}
