using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SatanCrossAttack : SatanasAttackController
{

    private Transform cross;

    private void Awake()
    {
        cross = transform.GetChild(0);
    }

    private void OnEnable()
    {
        cross.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (!cross.gameObject.activeSelf)
            newAtt();
    }


}
