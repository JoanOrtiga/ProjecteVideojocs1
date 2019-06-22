using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatanasFirePlatforms : SatanasAttackController {

    public GameObject[] firePlatforms;

    private void OnEnable()
    {
        firePlatforms[randomPlatform()].SetActive(true);

        if (Random.Range(0, 100) < satanModel.chanceOf2Platforms)
        {
            int rnd;

            do
            {
                rnd = randomPlatform();

                print(rnd + "  " +  firePlatforms[rnd].activeSelf);
            } while (firePlatforms[rnd].activeSelf);

            firePlatforms[rnd].SetActive(true);
        }
    }

    private int randomPlatform()
    {
        return Random.Range(0, 3);
    }

    private void Update()
    {

        if (!firePlatforms[0].activeSelf && !firePlatforms[1].activeSelf && !firePlatforms[2].activeSelf)
        {
            base.newAtt();
        }
            
    }
}
