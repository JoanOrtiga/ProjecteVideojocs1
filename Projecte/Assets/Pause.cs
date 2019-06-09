using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
    
    [SerializeField]
    private GameObject pausePanel;
    bool active = false; 

	void Update ()
    {
	    if (Input.GetButtonDown("Pause"))
        {
            print("GAS");  
            active = !active;
         
            Time.timeScale = (active) ? 0 : 1f;
        }
        pausePanel.SetActive(active);
    }
}