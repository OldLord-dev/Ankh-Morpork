using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleep : MonoBehaviour
{
    [SerializeField]
    InputHandler inputHandler;
    [SerializeField]
    GameObject go;
    bool canUse;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canUse=true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {                go.SetActive(true);
                inputHandler.SetCursorState(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        go.SetActive(false);
        inputHandler.SetCursorState(true);
    }
}
