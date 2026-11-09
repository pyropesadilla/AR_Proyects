using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class test : MonoBehaviour
{
    public Animator animator;
    public void Animacion()
    {
        animator.SetBool("Robot", true);
    }

}
