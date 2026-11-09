using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class A2 : MonoBehaviour
{
    public GameObject[] objetosfase0; 
    public GameObject[] objetosfase1;
    private bool activos = false;
    
    void Start()
    {
     foreach (GameObject obj in objetosfase1)
            {
                obj.SetActive(activos);
            }   
    }

    public void fase1()
    {
        foreach (GameObject obj in objetosfase0)
            {
                obj.SetActive(activos);
            }
        activos=!activos;
        foreach (GameObject obj in objetosfase1)
            {
                obj.SetActive(activos);
            } 
    }
}
