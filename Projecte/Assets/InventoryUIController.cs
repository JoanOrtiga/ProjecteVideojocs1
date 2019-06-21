using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIController : MonoBehaviour {

    private int currentIndex = 0;
    private Image[] inventorySlots;
    private PlayerInventory inv;

    // Use this for initialization
    void Start()
    {
        inventorySlots = GetComponentsInChildren<Image>();
        inv = GameManager.instance.getPlayerInv();
        UpdateInventorySlider();
        inv.updateStockEvent.AddListener(UpdateInventorySlider);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("InventorySelection1"))
        {          
            inv.Consume(currentIndex, 1);
        }
    }

    private void UpdateInventorySlider()
    {
        int index = currentIndex;
        int maxIndex = Mathf.Min(currentIndex + 3, inv.size - 1);

        foreach (Image img in inventorySlots)
        {
            if (index > maxIndex)
            {
                img.enabled = false;
                img.GetComponentInChildren<Text>().enabled = false  ;

                img.sprite = null;
                img.GetComponentInChildren<Text>().text = "";
            }
            else
            {
                Item itm = inv.GetInfo(index);
                img.enabled = true;
                img.GetComponentInChildren<Text>().enabled = true;
                img.sprite = itm.displayImage;
                img.GetComponentInChildren<Text>().text = itm.quantity.ToString();
            }

            index++;
        }
    }
}
