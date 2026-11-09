using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Placas : MonoBehaviour
{
    public Animator animator;
    public int number;
    

    void Start()
    {
        number=0;
        animator.SetBool("Abrir", false);
        animator.SetBool("Funcionar", false);
        animator.SetBool("Cerrar", false);
    }
    void Update()
    {
         Debug.Log("num:"+ number);
        if (number==1)
        {
            animator.SetBool("Abrir", true);
            animator.SetBool("Funcionar", false);
            animator.SetBool("Cerrar", false);
        }
        if (number==2)
        {
            animator.SetBool("Abrir", false);
            animator.SetBool("Funcionar", true);
            animator.SetBool("Cerrar", false);
        }
        if (number==3)
        {
            animator.SetBool("Abrir", false);
            animator.SetBool("Funcionar", false);
            animator.SetBool("Cerrar", true);
        }
        if(number>=4)
        {number=0;}
    }
    public void fases()
    {
        number+=1;
    }
}
