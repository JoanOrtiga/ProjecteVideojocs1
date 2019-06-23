using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

    private bool bossAlive = false;

    private void Update()
    {
        if (GameObject.Find("Boss") != null)
        {
            bossAlive = true;
        }

        if (bossAlive == true)
        {
            if (GameObject.Find("Boss") == null)
            {
                SceneManager.LoadScene("EndGame");
            }
        }
    }
}
