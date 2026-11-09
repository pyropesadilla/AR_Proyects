using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Muro : MonoBehaviour
{
    
    public Animator animator;
    public void AnimacionMuro()
    {
        StartCoroutine(AnimacionMuroCoroutine());
    }


    private IEnumerator AnimacionMuroCoroutine()
    {
        animator.SetBool("muro_ani", true);

        yield return new WaitForSeconds(1); 

        animator.SetBool("muro_ani", false);
    }


    
}
