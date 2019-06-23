using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowHealthIUI : MonoBehaviour {

    

    [SerializeField]
    private GameObject lowHealthImage;
    public float minHealth = 120;

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.getplayerHealth() <= minHealth)
        { 
            if(lowHealthImage != null)
                lowHealthImage.SetActive(true);
        }

        if (GameManager.instance.getplayerHealth() > minHealth)
        {
            if (lowHealthImage != null)
                lowHealthImage.SetActive(false);
            
        }
    }
}
