using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    GameObject pausePanel;
    bool active; 

	// Use this for initialization
	void Start ()
    {
        pausePanel = GameObject.FindGameObjectWithTag("Pause");
        pausePanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetButtonDown("Pause"))
        {
            print("GAS");  
            active = !active;
            pausePanel.SetActive(active);

            Time.timeScale = (active) ? 0 : 1f;
        }	
	}
}