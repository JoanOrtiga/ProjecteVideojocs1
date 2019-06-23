using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBoss : MonoBehaviour
{
    public GameObject shakeCamera;
    public GameObject bossLimits;

    public GameObject boss1;
    public Vector2 spawnPlace;
    public Vector2[] spawnPlaceLimit;

    public float time = 1.5f;

    private bool playedOnce = false;

    private void Update()
    {
        if (GetComponentsInChildren<RelicInAltar>(true)[0].relicPlaced && GetComponentsInChildren<RelicInAltar>(true)[1].relicPlaced && GetComponentsInChildren<RelicInAltar>(true)[2].relicPlaced)
        {
            if (!playedOnce)
            {
                playedOnce = true;

                GameObject bossWalls = new GameObject();

                Instantiate(bossWalls, new Vector2(0, 0), new Quaternion(0, 0, 0, 0));
                bossWalls.name = "bossWalls";

                Instantiate(bossLimits, spawnPlaceLimit[0], bossLimits.transform.rotation).transform.parent = bossWalls.transform;
                Instantiate(bossLimits, spawnPlaceLimit[1], bossLimits.transform.rotation * new Quaternion(0,0,90,90)).transform.parent = bossWalls.transform;
                Instantiate(bossLimits, spawnPlaceLimit[2], bossLimits.transform.rotation).transform.parent = bossWalls.transform;

                Instantiate(shakeCamera, transform.position, transform.rotation);

                StartCoroutine(spawnTime());
            }
        }
    }

    IEnumerator spawnTime()
    {
        yield return new WaitForSeconds(time);
        Instantiate(boss1, spawnPlace, transform.rotation);

        foreach (Transform child in transform)
        {
            Destroy(child.gameObject);
        }

        Destroy(GameObject.Find("ShakeCameraZone(Clone)"));
        
        Destroy(gameObject);
    }

}
