using UnityEngine;
using System.Collections;

public class Attack2State_Boss1 : Boss1State
{
    public GameObject fireBall;

    private float time1 = 0.4f;
    private float time2 = 3f;

    // Use this for initialization
    private void OnEnable()
    {
        StartCoroutine(attack2());
    }

    IEnumerator attack2()
    {
        yield return new WaitForSeconds(time1);
        Instantiate(fireBall, rb2d.transform.position, transform.rotation);
        yield return new WaitForSeconds(time1);
        Instantiate(fireBall, rb2d.transform.position, transform.rotation);
        yield return new WaitForSeconds(time1);
        Instantiate(fireBall, rb2d.transform.position, transform.rotation);
        yield return new WaitForSeconds(time1);
        Instantiate(fireBall, rb2d.transform.position, transform.rotation);
        yield return new WaitForSeconds(time1);
        Instantiate(fireBall, rb2d.transform.position, transform.rotation);
        yield return new WaitForSeconds(time2);

        GetComponent<MovingState_Boss1>().attacking = false;
        GetComponent<Attack2State_Boss1>().enabled = false;
    }
}
