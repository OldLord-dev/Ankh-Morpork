using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAttack : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    // Start is called before the first frame update
public void AnimDone()
    {
        anim.SetTrigger("Attack");
    }
}
