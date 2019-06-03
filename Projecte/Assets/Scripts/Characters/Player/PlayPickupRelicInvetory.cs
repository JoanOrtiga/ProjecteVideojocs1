using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPickupRelicInvetory : MonoBehaviour {


    public Image[] relic;

    [HideInInspector] public bool relic0 = false;
    [HideInInspector] public bool relic1 = false;
    [HideInInspector] public bool relic2 = false;
    



    // Use this for initialization
    void Start () {
        relic[0].enabled = false;
        relic[1].enabled = false;
        relic[2].enabled = false;

    }
	
	// Update is called once per frame
	void Update ()
    {
        relicUI();
		
	}
    public void relicUI()
    {
        if (relic0 == true) { relic[0].enabled = true; }
        else if (relic0 == false) { relic[0].enabled = false; }
       
        if (relic1 == true) {relic[1].enabled = true; }
        else if(relic1 == false) { relic[1].enabled = false; }


        if (relic2 == true)  { relic[2].enabled = true;    }
        else if (relic2 == false) { relic[2].enabled = false; }
    }
}
