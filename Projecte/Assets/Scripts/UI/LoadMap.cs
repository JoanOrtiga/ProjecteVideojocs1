using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadMap : MonoBehaviour
{
    public AudioClip soundEffect;
    public AudioSource soundAudioSource;
    

    [SerializeField]
    private GameObject map;
    private bool active = false;


    private void Start()
    {
        soundAudioSource.clip = soundEffect;
    }
    private void Update()
    {
        if (Input.GetButtonDown("Map"))
        {
            soundAudioSource.Play();
            active = !active;

            map.SetActive(active);

            Time.timeScale = (active) ? 0 : 1f;
        }


    }
}