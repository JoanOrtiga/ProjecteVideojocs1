using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUpDMG : PlayerState {


    public Renderer rendererGameObject;
    public BoxCollider2D boxColliderGameObject;

    public GameObject Ui;
    public AudioClip audioClip;
    public AudioSource audioSource;
    public float powerUpDmg = 100;
    public float durationTime  = 8;

    private float actualTime = 0;
    private float normalDmg;
    private bool oneTime = false;







    // Use this for initialization
    void Start () {

        
        normalDmg = GameManager.instance.swordDmg;
        
        rendererGameObject = GetComponent<Renderer>();
        boxColliderGameObject = GetComponent<BoxCollider2D>();
       

        audioSource.clip = audioClip;
    }


    private void Update()
    {
        //Debug.Log(actualTime);
        
        actualTime = actualTime + Time.deltaTime;


        if (actualTime >= durationTime && oneTime == true)
        {
            Ui.SetActive(false);
            GameManager.instance.swordDmg = normalDmg;
            Destroy(gameObject);
        }
    }


    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && oneTime == false)
        {
            Ui.SetActive(true);
            actualTime = 0;
            oneTime = true;
            rendererGameObject.enabled = false;
            boxColliderGameObject.enabled = false;
            audioSource.Play();
            GameManager.instance.swordDmg += powerUpDmg;
        }
        
    }
}
