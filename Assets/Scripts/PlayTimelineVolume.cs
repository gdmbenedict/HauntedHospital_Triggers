using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayTimelineVolume : MonoBehaviour
{
    [SerializeField] private PlayableDirector cutscene;
    public AudioSource audioSource;
    public float volume =1;


    // Start is called before the first frame update
    void Start()
    {
        if (volume > 1)
        {
            volume = 1;
        }
        if (volume < 0)
        {
            volume = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //method that plays timeline on trigger being called
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Stop();
        audioSource.volume = volume;
        cutscene.Play();
    }
}
