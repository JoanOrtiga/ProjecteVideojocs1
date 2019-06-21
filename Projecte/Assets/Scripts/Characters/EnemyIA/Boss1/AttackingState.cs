using UnityEngine;
using System.Collections;

public class AttackingState : Boss1State
{
    // Update is called once per frame
    void Update()
    {
        if (!attacking)
        {
            switch (Random.Range(0,3))
            {
                case 0:
                    attacking = true;
                    GetComponent<Attack1State_Boss1>().enabled = true;
                    break;

                case 1:
                    attacking = true;
                    GetComponent<Attack2State_Boss1>().enabled = true;
                    break;

                case 2:
                    attacking = true;
                    GetComponent<Attack3State_Boss1>().enabled = true;   
                    break;
            }
        }
    }
}
