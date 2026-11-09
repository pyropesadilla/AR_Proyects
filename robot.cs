using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class robot : MonoBehaviour
{
    public GameObject[] objetos; 
    private bool activos = false;
    void Start()
    {
     foreach (GameObject obj in objetos)
            {
                obj.SetActive(activos);
            }   
    }

    public void Area_grado_libertad()
    {
        activos=!activos;  
        foreach (GameObject obj in objetos)
            {
                if (obj != null)
                    obj.SetActive(activos);
            } 
    }

 
    
}
