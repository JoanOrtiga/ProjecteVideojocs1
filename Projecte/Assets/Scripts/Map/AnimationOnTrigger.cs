using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOnTrigger : MonoBehaviour {

    public GameObject obj;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            obj.GetComponent<Animation>().Play("troncoAni");
            Debug.Log("ANIMATION PLAY");
            Destroy(this);
        }
        
    }
}
