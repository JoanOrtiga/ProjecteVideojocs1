using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
    
    [SerializeField]
    private GameObject pausePanel;
    private bool active = false;

    private void Update ()
    {
	    if (Input.GetButtonDown("Pause"))
        {
            active = !active;

            pausePanel.SetActive(active);

            Time.timeScale = (active) ? 0 : 1f;

            GameManager.instance.paused = !GameManager.instance.paused;
        }      
    }
}