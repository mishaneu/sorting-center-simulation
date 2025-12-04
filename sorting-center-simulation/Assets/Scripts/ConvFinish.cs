using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConvFinish : MonoBehaviour
{
    public ConvStart checker;
    public Animator anim;
    public Animator anim2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Detail"))
        {
            checker.isMove = false;
            if (other is BoxCollider)
            {
                anim.SetTrigger("Start");

            }
            if (other is SphereCollider)
            {
                anim2.SetTrigger("Start");
            }
        }
    }
}
