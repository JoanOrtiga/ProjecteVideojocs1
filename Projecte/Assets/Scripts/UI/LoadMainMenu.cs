using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainMenu : MonoBehaviour {

    public void LoadScenes()
    {
        SceneManager.LoadScene(0);
        Destroy(GameObject.FindGameObjectWithTag("GameController").gameObject);
    }
}
