using UnityEngine;

public class Intercambiador_shell : MonoBehaviour
{
    
    // Lista de objetos a activar/desactivar
    public GameObject[] objetos;

    // Tiempo entre cambios
    public float intervalo = 5f;

    private float tiempoTranscurrido = 0f;
    private bool activos = true;

    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;

        if (tiempoTranscurrido >= intervalo)
        {
            // Cambia el estado de los objetos
            activos = !activos;

            foreach (GameObject obj in objetos)
            {
                if (obj != null)
                {
                    obj.SetActive(activos);
                }
            }

            tiempoTranscurrido = 0f;
        }
    }
}


