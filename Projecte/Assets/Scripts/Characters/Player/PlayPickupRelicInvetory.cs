using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPickupRelicInvetory : MonoBehaviour {

    
    public Image[] relic;

    [HideInInspector] public bool relic_grail = false;
    [HideInInspector] public bool relic_bible = false;
    [HideInInspector] public bool relic_cross = false;

    /*private bool AudioActiveRelic0 = false;
    private bool AudioActiveRelic1 = false;
    private bool AudioActiveRelic2 = false;*/
    //  private AudioSource source;



    // Use this for initialization
    void Start () {
        //source = GetComponent<AudioSource>();
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
        if (relic_grail == true) { relic[0].enabled = true;  }
    
       
        if (relic_bible == true) {relic[1].enabled = true; }
        else if(relic_bible == false) { relic[1].enabled = false; }


        if (relic_cross == true)  { relic[2].enabled = true;    }
        else if (relic_cross == false) { relic[2].enabled = false; }
    }
}
