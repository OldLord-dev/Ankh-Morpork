using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    AudioSource song;
    [SerializeField]
    AudioSource frog;
    float baseVolume;
    void Start()
    {
        baseVolume = song.volume;
    }
    bool playerEnter;
    int i = 0;
    float t=0;
    private void Update()
    {
        if (i == 1)
        {
            if (playerEnter)
            {
                song.volume = Mathf.Lerp(song.volume, 0.1f, t);
                frog.volume = Mathf.Lerp(frog.volume, 0.1f, t);
                t += 0.1f * Time.deltaTime;
                if (t > 1.0f)
                {
                    i = 0;
                    t = 0.0f;
                }
                    
            }
            else
            {
                song.volume = Mathf.Lerp(song.volume, baseVolume, t);
                frog.volume = Mathf.Lerp(frog.volume, baseVolume, t);
                t += 0.1f * Time.deltaTime;
                if (t > 1.0f)
                {
                    i = 0;
                    t = 0.0f;
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            i = 1;
            t = 0.0f;
            playerEnter = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            i = 1;
            t = 0.0f;
            playerEnter = false;  
        }

    }
}
