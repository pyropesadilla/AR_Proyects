using UnityEngine;

public class Flechas : MonoBehaviour
{
    [Header("Configuración de materiales y colores")]
    public Material material;
    public Color[] colours;

    [Header("Rango de altura relativa (local Y)")]
    public float minLocalY = 0f;
    public float maxLocalY = 10f;

    void Update()
    {
        ApplyColorByRelativeHeight();
    }

    void ApplyColorByRelativeHeight()
    {
        if (colours == null || colours.Length < 2) return;

        // Usar la posición local en el eje Y (relativa al padre)
        float localY = transform.localPosition.y;

        // Convertir la posición Y local a un valor entre 0 y 1
        float normalizedY = Mathf.InverseLerp(minLocalY, maxLocalY, localY);

        // Determinar entre qué dos colores estamos
        float segment = normalizedY * (colours.Length - 1);
        int lowerIndex = Mathf.FloorToInt(segment);
        int upperIndex = Mathf.Clamp(lowerIndex + 1, 0, colours.Length - 1);

        float t = segment - lowerIndex; // Fracción entre los dos colores

        // Interpolación lineal de color
        Color lerpedColor = Color.Lerp(colours[lowerIndex], colours[upperIndex], t);

        // Aplicar el color al material
        material.color = lerpedColor;
    }
}
