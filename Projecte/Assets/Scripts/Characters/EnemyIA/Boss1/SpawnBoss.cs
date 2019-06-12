using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnBoss : MonoBehaviour
{
    public GameObject shakeCamera;
   
    public GameObject boss1;
    public Image PressF;
    public Vector2 spawnPlace;

    public float time = 1.5f;

    private void Update()
    {
        if(GetComponentsInChildren<RelicInAltar>(true)[0].relicPlaced && GetComponentsInChildren<RelicInAltar>(true)[1].relicPlaced && GetComponentsInChildren<RelicInAltar>(true)[2].relicPlaced)
        {
            

            Instantiate(shakeCamera, transform.position, transform.rotation);




            StartCoroutine(spawnTime());


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

        Destroy(gameObject);
    }

}
