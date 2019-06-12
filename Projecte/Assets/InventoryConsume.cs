using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryConsume : MonoBehaviour {

    private void Start()
    {
        GameManager.instance.getPlayerInv().itemSelectionEvent.AddListener(ItemSelection);
    }

    private void ItemSelection(Item itm)
    {
        HPpotionModel potion = itm as HPpotionModel;
        if (potion != null)
        {
            
            GameManager.instance.playerHpUp(potion.healthUp);

            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerState>().updateHealthBar();
        }
    }
}
