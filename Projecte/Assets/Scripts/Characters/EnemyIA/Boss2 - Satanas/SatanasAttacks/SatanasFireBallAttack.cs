using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatanasFireBallAttack : SatanasAttackController {

    public GameObject fireBall;

    private void OnEnable()
    {
        StartCoroutine(FireBall());
    }

    IEnumerator FireBall()
    {
        yield return new WaitForSeconds(satanModel.timeBetweenFireBall);
        Instantiate(fireBall, rb2d.transform.position, rb2d.transform.rotation);
        yield return new WaitForSeconds(satanModel.timeBetweenFireBall);
        Instantiate(fireBall, rb2d.transform.position, rb2d.transform.rotation);
        yield return new WaitForSeconds(satanModel.timeBetweenFireBall);
        Instantiate(fireBall, rb2d.transform.position, rb2d.transform.rotation);
        yield return new WaitForSeconds(satanModel.timeBetweenFireBall);
        Instantiate(fireBall, rb2d.transform.position, rb2d.transform.rotation);
        yield return new WaitForSeconds(satanModel.timeBetweenFireBall);
        Instantiate(fireBall, rb2d.transform.position, rb2d.transform.rotation);

        yield return new WaitForSeconds(satanModel.coolDownBetweenAttacks);

        base.newAtt();
    }
}
