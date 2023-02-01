using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEventListener : MonoBehaviour
{
    Animator anim;
    public bool AttackInProgress { get; private set; } = false;
    [SerializeField]
    private BoxCollider boxCollider;
    //[SerializeField]
    //private BoxCollider axeCollider;
    //[SerializeField]
    //private Transform leftHandTransform;
    Collider coll;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    //public void OnGrabAnimation()
    //{
    //    coll.gameObject.transform.position = leftHandTransform.position;
    //    coll.gameObject.transform.position= coll.ClosestPoint(coll.gameObject.transform.position)-Vector3.up*0.1f;
    //    coll.gameObject.transform.SetParent(leftHandTransform, true);

    //}
    public void AnimationDone()
    {
       // anim.SetBool("PickUp", false);
       // anim.SetBool("CanPickUp", false);
        //coll.gameObject.transform.parent.DetachChildren();
       // coll.gameObject.SetActive(false);   
    }
    private void SetAttackStart()
    {
        // Attacking
        //AttackInProgress = true;
        boxCollider.enabled = true;
        anim.SetBool("Attacking", true);
    }

    private void SetAttackEnd()
    {
        boxCollider.enabled = false;
        anim.SetBool("Attacking", false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        { 
            coll = other;
            anim.SetBool("CanPickUp", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
                anim.SetBool("CanPickUp", false);
        }
    }

    public void TurnOnCollider()
    {
        boxCollider.enabled = true;
        //axeCollider.enabled = true;
    }
    public void OnAnimationEnd()
    {
        boxCollider.enabled = false;
       // axeCollider.enabled = false;
    }
}
