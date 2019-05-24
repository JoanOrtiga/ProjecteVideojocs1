using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikesAttack : MonoBehaviour
{

    private float time1 = 1f;
    private float time2 = 0.3f;
    private float timeToDestroy = 1f;

    private bool up = false;

    Transform spikesT;
    SpriteRenderer spikesSR;
    Vector2 finishPoint;

    void Start()
    {
        spikesT = GetComponentsInChildren<Transform>()[1];
        spikesSR = GetComponentsInChildren<SpriteRenderer>()[1];


        finishPoint = new Vector2(spikesT.position.x, spikesT.position.y + 0.77f);

        StartCoroutine(DoDmg());
    }

    IEnumerator DoDmg()
    {
        yield return new WaitForSeconds(time1*1/6);
        spikesSR.color = new Color(spikesSR.color.r, spikesSR.color.g, spikesSR.color.b, 0.1f);
        yield return new WaitForSeconds(time1 * 1 / 6);
        spikesSR.color = new Color(spikesSR.color.r, spikesSR.color.g, spikesSR.color.b, 0.25f);
        yield return new WaitForSeconds(time1 * 1 / 6);
        spikesSR.color = new Color(spikesSR.color.r, spikesSR.color.g, spikesSR.color.b, 0.40f);
        yield return new WaitForSeconds(time1 * 1 / 6);
        spikesSR.color = new Color(spikesSR.color.r, spikesSR.color.g, spikesSR.color.b, 0.5f);
        yield return new WaitForSeconds(time1 * 1 / 6);
        spikesSR.color = new Color(spikesSR.color.r, spikesSR.color.g, spikesSR.color.b, 0.70f);
        yield return new WaitForSeconds(time1 * 1 / 6);
        spikesSR.color = new Color(spikesSR.color.r, spikesSR.color.g, spikesSR.color.b, 0.85f);

        yield return new WaitForSeconds(time2);
        spikesSR.color = new Color(spikesSR.color.r, spikesSR.color.g, spikesSR.color.b, 1f);
        up = true;

        yield return new WaitForSeconds(timeToDestroy);

        Destroy(gameObject);

    }
    
    void Update()
    {
        if (up)
        {
            spikesT.position = Vector2.Lerp(spikesT.position, finishPoint, 0.2f);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && up)
        {
            GameManager.instance.playerGetDmg(GameManager.instance.boss1_model.attackSpikesDmg);
        }
    }
}
