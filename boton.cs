using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Android;
public class boton : MonoBehaviour
{

    public Animator animator;
    public Animator Muro;
    public GameObject[] objetos;
    private bool CascaraCerrada= true;
    

    private int limiteDeFps=15;
    private bool activos = false;
    void Start()
    {
        Application.targetFrameRate=limiteDeFps;
        //objetos del intercambiador
        foreach (GameObject obj in objetos)
            {
                obj.SetActive(activos);
            }

        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }
    }

    public void CambiarEscena(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void AnimacionCascara()
    {
        if(CascaraCerrada==true)
        {animator.SetBool("Cascara", true);
        StartCoroutine(EsperarYActivarObjetos());}
        else
        {animator.SetBool("Cascara", false);
        activos = !activos;

        foreach (GameObject obj in objetos)
        {
            if (obj != null)
                obj.SetActive(activos);
        }
        }
        CascaraCerrada=!CascaraCerrada;
    } 

    public void AnimacionMuro()
    {
        animator.SetBool("muro_ani", true);
        //animator.SetBool("muro_ani", false);
    }

    private IEnumerator EsperarYActivarObjetos()
    {
        yield return new WaitForSeconds(2);

        activos = !activos;

        foreach (GameObject obj in objetos)
        {
            if (obj != null)
                obj.SetActive(activos);
        }
    }
    
    private IEnumerator DesactivarCascara()
    {
        yield return new WaitForSeconds(5);
        animator.SetBool("Cascara", false);
    }

    public void Quit(){
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

}
