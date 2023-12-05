using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerController : MonoBehaviour
{
    private bool isFlickering = false;
    private float timeDelay;
    [SerializeField] private float minOffTime = 0.05f, maxOffTime = 0.15f, minOnTime = 0.01f, maxOnTime = 0.8f;

    [Header("Game Objects")]
    [SerializeField] private GameObject lightOn;
    [SerializeField] private GameObject lightOff;

    // Update is called once per frame
    void Update()
    {
        if (isFlickering == false)
        {
            StartCoroutine(FlickeringLight());
        }
 
    }

    IEnumerator FlickeringLight()
    {
        isFlickering = true;
        lightOn.SetActive(false);
        lightOff.SetActive(true);
        timeDelay = Random.Range(minOffTime, maxOffTime);
        yield return new WaitForSeconds(timeDelay);
        lightOn.SetActive(true);
        lightOff.SetActive(false);
        timeDelay = Random.Range(minOnTime, maxOnTime);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;

    }
}
