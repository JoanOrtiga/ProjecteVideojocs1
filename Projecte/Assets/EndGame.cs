using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

    [SerializeField]
    private GameObject endGame;
    private bool bossAlive = false;

    private void Update()
    {
        if (GameObject.Find("Boss(Clone)") != null)
        {
            bossAlive = true;

        }

        if (bossAlive == true)
        {
            if (GameObject.Find("Boss(Clone)") == null)
            {
                endGame.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void LoadScenes()
    {
        SceneManager.LoadScene(0);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
