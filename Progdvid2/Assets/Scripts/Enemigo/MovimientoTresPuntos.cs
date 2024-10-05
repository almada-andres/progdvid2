using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoTresPuntos : MonoBehaviour
{
    public float distanciaHorizontal = 3f; // Distancia en el eje X (derecha o izquierda)
    public float distanciaVertical = 2f; // Distancia en el eje Y (arriba o abajo)
    public float velocidad = 2f; // Velocidad de movimiento

    private Vector2 puntoA; // Posición inicial
    private Vector2 puntoB; // Desplazamiento en el eje X
    private Vector2 puntoC; // Desplazamiento en el eje Y
    private Vector2 objetivoActual; // El punto objetivo actual
    private int indiceObjetivo = 0; // Para alternar entre los puntos

    void Start()
    {
        // Definimos los tres puntos basados en la posición inicial
        puntoA = transform.position;
        puntoB = new Vector2(transform.position.x + distanciaHorizontal, transform.position.y);
        puntoC = new Vector2(puntoB.x, puntoB.y + distanciaVertical);

        // Empezamos moviéndonos hacia el punto B
        objetivoActual = puntoB;
    }

    void Update()
    {
        // Movemos el enemigo hacia el objetivo actual
        transform.position = Vector2.MoveTowards(transform.position, objetivoActual, velocidad * Time.deltaTime);

        // Si el enemigo llega al objetivo, cambiamos al siguiente punto
        if (Vector2.Distance(transform.position, objetivoActual) < 0.1f)
        {
            CambiarObjetivo();
        }
    }

    void CambiarObjetivo()
    {
        // Alternar entre los puntos A - B - C - A
        if (indiceObjetivo == 0)
        {
            objetivoActual = puntoB;
            indiceObjetivo = 1;
        }
        else if (indiceObjetivo == 1)
        {
            objetivoActual = puntoC;
            indiceObjetivo = 2;
        }
        else
        {
            objetivoActual = puntoA;
            indiceObjetivo = 0;
        }
    }
}
