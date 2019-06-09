using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    [SerializeField]
    private GameObject gameOver;
	
	// Update is called once per frame
	void Update ()
    {
        if(GameManager.instance.getplayerHealth() <= 0)
        {
            gameOver.SetActive(true);
        }
    }
}
