using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorListener : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("AnimDone", true);
    }
    public void AnimStart()
    {
        animator.SetBool("AnimDone", false);
    }

public void AnimDone()
    {
        animator.SetBool("AnimDone", true);
    }

}
