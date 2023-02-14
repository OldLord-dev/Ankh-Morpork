using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig : MonoBehaviour
{
    public Animator anim;
    public Animator anim2;
    public GameObject muzyka;
    public GameObject muzyka2;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("Open", true);
            anim2.SetBool("Open", true);
            if (muzyka || muzyka2)
            {
                muzyka.SetActive(true);
                muzyka2.SetActive(false);
            }

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("Open", false);
            anim2.SetBool("Open", false);
        }
    }
}
