using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatanasFirePlatforms : MonoBehaviour {

    public GameObject[] firePlatforms;

    private int[] activeFire = new int[2];

    private void OnEnable()
    {
        firePlatforms[randomPlatform()].SetActive(true);


        int rnd;

        do
        {
            rnd = randomPlatform();

        } while (firePlatforms[rnd].activeSelf);

        firePlatforms[rnd].SetActive(true);
    }

    private int randomPlatform()
    {
        return Random.Range(0, 3);
    }
}
