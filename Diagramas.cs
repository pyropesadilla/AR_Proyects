using UnityEngine;

public class Diagramas : MonoBehaviour
{
    
    public GameObject Diagrama;
    bool variable=false;

    public void Activar()
    {
        variable=!variable;
    }

    void Update()
    {
        Diagrama.SetActive(variable);
    }
}
