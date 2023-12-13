using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //variables
    private bool triggered;
    [SerializeField] GameObject endscreen;

    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
        endscreen.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!triggered)
        {
            triggered=true;
            endscreen.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;

        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
