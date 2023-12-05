using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayTimeline : MonoBehaviour
{
    [SerializeField] private PlayableDirector cutscene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //method that plays timeline on trigger being called
    private void OnTriggerEnter(Collider other)
    {
        cutscene.Play();
    }
}
