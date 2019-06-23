using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    [SerializeField]
    private GameObject gameOver;

    private void Start()
    {
        gameOver = GameObject.FindGameObjectWithTag("GameOver");
    }


    // Update is called once per frame
    void Update ()
    {
        if(GameManager.instance.getplayerHealth() <= 0)
        {
            if(gameOver != null)
                gameOver.SetActive(true);

            Time.timeScale = (true) ? 0 : 1f;
            GameManager.instance.paused = true;
        }

        if (Input.GetButton("Restart") && gameOver.activeSelf)
        {
            SceneManager.LoadScene(0);
        }
    }
}
