using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DieControl : MonoBehaviour
{
    bool died = false;
    int hit = 0;
    public AI ai;
    public Animator animator;
    public NavMeshAgent agent;
    public Rigidbody rb;

    void Update()
    {
        if (died)
        {
            ai.enabled = false;
            animator.enabled = false;
            agent.enabled = false;
            StartCoroutine("DieTime");
        }
    }
        IEnumerator DieTime()
    {
        yield return new WaitForSeconds(5);
        gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sword"))
        {
            if(hit<3)
                hit++;
            if (hit == 3)
            {
                died = true;
                rb.AddForce(-Vector3.forward*150);
            }
                
        }
    }
}
