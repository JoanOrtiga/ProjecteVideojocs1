using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPickupRelicInvetory : MonoBehaviour {

    
    private AudioSource source;
    public Image[] relic;

    [HideInInspector] public bool relic0 = false;
    [HideInInspector] public bool relic1 = false;
    [HideInInspector] public bool relic2 = false;

    private bool AudioActiveRelic0 = false;
    private bool AudioActiveRelic1 = false;
    private bool AudioActiveRelic2 = false;


    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
        relic[0].enabled = false;
        relic[1].enabled = false;
        relic[2].enabled = false;

    }
	
	// Update is called once per frame
	void Update ()
    {
        relicUI();
        relicSound();
		
	}
    public void relicSound()
    {

        // if (relic0 == true && AudioActiveRelic0 != false) Debug.Log("SOUNDS222"); source.PlayOneShot(GameManager.playerModel.pickUpSound); AudioActiveRelic0 = true;
        //  if (relic1 == true && AudioActiveRelic1 == false) Debug.Log("SOUNDS222"); source.PlayOneShot(GameManager.playerModel.pickUpSound); AudioActiveRelic1 = true;
        //  if (relic2 == true && AudioActiveRelic2 == false) Debug.Log("SOUNDS222"); source.PlayOneShot(GameManager.playerModel.pickUpSound); AudioActiveRelic2 = true;


    }

    public void relicUI()
    {
        if (relic0 == true) { relic[0].enabled = true;  }
        else if (relic0 == false) { relic[0].enabled = false; }
       
        if (relic1 == true) {relic[1].enabled = true; }
        else if(relic1 == false) { relic[1].enabled = false; }


        if (relic2 == true)  { relic[2].enabled = true;    }
        else if (relic2 == false) { relic[2].enabled = false; }
    }
}
