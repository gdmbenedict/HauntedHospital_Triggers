using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnce : MonoBehaviour
{
    public AudioSource audioSource;
    bool played = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!played)
        {
            played = true;
            audioSource.Play();
        } 
    }
}
