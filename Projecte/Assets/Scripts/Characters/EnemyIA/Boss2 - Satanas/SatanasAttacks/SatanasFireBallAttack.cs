using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatanasFireBallAttack : SatanasAttackController {

    public GameObject fireBall;

    private void OnEnable()
    {
        StartCoroutine(FireBall());
        InvokeRepeating("SpawnFireBall", 0, satanModel.timeBetweenFireBall);
    }

    private void SpawnFireBall()
    {
        Instantiate(fireBall, rb2d.transform.position, rb2d.transform.rotation);
    }
    
    private IEnumerator FireBall()
    {
        yield return new WaitForSeconds(satanModel.fireBallCooldownAfterAttack);
        CancelInvoke("SpawnFireBall");

        yield return new WaitForSeconds(satanModel.coolDownBetweenAttacks);
        base.newAtt();
    }
}
