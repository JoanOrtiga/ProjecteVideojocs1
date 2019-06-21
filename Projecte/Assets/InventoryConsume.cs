using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryConsume : MonoBehaviour {

    public AudioClip audioClip;
    public AudioSource audioSource;

    private void Start()
    {
        audioSource.clip = audioClip;
        GameManager.instance.getPlayerInv().itemSelectionEvent.AddListener(ItemSelection);
    }

    private void ItemSelection(Item itm)
    {
        HPpotionModel potion = itm as HPpotionModel;
        if (potion != null)
        {
            audioSource.Play();
            GameManager.instance.playerHpUp(potion.healthUp);

            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerState>().updateHealthBar();
        }
    }
}
