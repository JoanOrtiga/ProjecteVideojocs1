﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    [SerializeField]
    private GameObject gameOver;
	
	// Update is called once per frame
	void Update ()
    {
        if(GameManager.instance.getplayerHealth() <= 0)
        {
            if(gameOver!=null)
                gameOver.SetActive(true);
            //Time.timeScale = 0f;
        }

        if (Input.GetButton("Restart") && gameOver.activeSelf)
        {
            SceneManager.LoadScene(0);
            Destroy(gameObject);
           
        }
    }
}
