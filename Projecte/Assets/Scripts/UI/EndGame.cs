using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

    private bool bossAlive = false;
    private bool oneTime = false;

    private void Update()
    {
        if (GameObject.Find("Boss(Clone)") != null)
        {
            bossAlive = true;
            
        }

        if (bossAlive == true)
        {
            if (GameObject.Find("Boss(Clone)") == null && oneTime ==false)
            {
                oneTime = true;
                SceneManager.LoadScene(3);
            }
        }
    }
}
