using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaAttack : MonoBehaviour {

    private float coolDown;
    private SpriteRenderer spr;

    private bool doDmg = false;

	// Use this for initialization
	void Start () {
        coolDown = GameManager.instance.satanModel.timeOfLive;
        spr = GetComponent<SpriteRenderer>();
        spr.color = new Color(spr.color.r, spr.color.g, spr.color.b, 0f);

        this.gameObject.SetActive(false);
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (doDmg)
        {
            if(collision.tag == "Player")
            {
                collision.GetComponent<PlayerState>().getDmg(GameManager.instance.satanModel.lavaDamage * Time.deltaTime);
            }
        }
    }

    private void Update()
    {
 
    }

    private void OnEnable()
    {
        if(spr != null)
            StartCoroutine(Lava());
    }
    

    private IEnumerator Lava()
    {
        Color tmp = spr.color;

        tmp.a = 0.1f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.2f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.3f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.4f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.5f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.6f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.7f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.8f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.9f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 1f;
        doDmg = true;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.timeOfLive);
        tmp.a = 0.9f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        doDmg = false;
        spr.color = tmp;
        tmp.a = 0.8f;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.7f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.6f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.5f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.4f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.3f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.2f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0.1f;
        spr.color = tmp;
        yield return new WaitForSeconds(GameManager.instance.satanModel.marginTime * 0.15f);
        tmp.a = 0;
        spr.color = tmp;

        yield return new WaitForSeconds(GameManager.instance.satanModel.coolDownBetweenAttacks);
        gameObject.SetActive(false);
    }
}
