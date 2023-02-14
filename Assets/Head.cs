using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

public void HeadHit()
    {
        rb.isKinematic = false;
    }

}
