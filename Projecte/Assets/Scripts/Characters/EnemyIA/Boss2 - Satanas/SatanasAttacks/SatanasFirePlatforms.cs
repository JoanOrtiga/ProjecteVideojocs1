using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatanasFirePlatforms : SatanasAttackController {

    private GameObject platform;
    private GameObject[] FirePlatforms = new GameObject[3];

    private void Awake()
    {
        platform = GameObject.FindGameObjectWithTag("BossComponents");

        FirePlatforms[0] = platform.transform.GetChild(3).gameObject;
        FirePlatforms[1] = platform.transform.GetChild(4).gameObject;
        FirePlatforms[2] = platform.transform.GetChild(5).gameObject;
    }

    private void OnEnable()
    {
        FirePlatforms[randomPlatform()].SetActive(true);
        print(FirePlatforms[0].activeSelf);
        print(FirePlatforms[1].activeSelf);
        print(FirePlatforms[2].activeSelf);

        if (Random.Range(0, 100) < satanModel.chanceOf2Platforms)
        {
            int rnd;
            int safeCount = 0;
            do
            {
                rnd = randomPlatform();

                safeCount++;

            } while (FirePlatforms[rnd].activeSelf && safeCount < 50f);

            if(safeCount > 49)
            {
                base.newAtt();
            }

            FirePlatforms[rnd].SetActive(true);
        }
    }

    private int randomPlatform()
    {
        return Random.Range(0, 3);
    }

    private void Update()
    {
        if (!FirePlatforms[0].activeSelf && !FirePlatforms[1].activeSelf && !FirePlatforms[2].activeSelf)
        {
            base.newAtt();
        }   
    }
}
