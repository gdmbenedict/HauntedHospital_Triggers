using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioOnceVolume : MonoBehaviour
{
    public AudioSource audioSource;
    public float volume =1;
    bool played = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!played)
        {
            //set volume to appropriate level
            if (volume > 1)
            {
                volume = 1;
            }
            else if (volume < 0)
            {
                volume = 0;
            }

            audioSource.volume = volume;

            played = true;
            audioSource.Play();
        } 
    }
}
