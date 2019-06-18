using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class InventoryButtonsController : MonoBehaviour {

    [HideInInspector] public bool isMoving;

    private ButtonAnimation[] buttons;

    private void Start()
    {
        isMoving = false;
    }

    private void Update()
    {
       foreach (ButtonAnimation b in buttons)
        {
            if (!b.gameObject.GetComponent<ButtonAnimation>().isMoving && !b.gameObject.GetComponent<ButtonAnimation>().up)
                StartCoroutine(AnimateButton(b.gameObject, false));
        }
    }

    public IEnumerator AnimateButton(GameObject button, bool up)
    {
        if (up)
        {
            float yPos = Mathf.Lerp(button.GetComponent<RectTransform>().anchoredPosition.y, -76, 0.2f);
            button.GetComponent<RectTransform>().anchoredPosition = new Vector2(button.GetComponent<RectTransform>().anchoredPosition.x, yPos);
            if (button.GetComponent<RectTransform>().anchoredPosition.y <= -121.5) yield return null;
        }
        else
        {
            float yPos = Mathf.Lerp(button.GetComponent<RectTransform>().anchoredPosition.y, -185, 0.2f);
            button.GetComponent<RectTransform>().anchoredPosition = new Vector2(button.GetComponent<RectTransform>().anchoredPosition.x, yPos);
            if (button.GetComponent<RectTransform>().anchoredPosition.y >= -174.5) yield return null;
        }
        isMoving = false;
    }
}
