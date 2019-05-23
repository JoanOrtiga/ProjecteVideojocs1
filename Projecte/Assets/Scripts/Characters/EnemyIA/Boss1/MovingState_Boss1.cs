using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Boss1State))]
public class MovingState_Boss1 : Boss1State
{
    public enum BossPositions
    {
        left, center, right
    }

    private BossPositions position = BossPositions.center;

    private int movementNumber;
    private bool finishedMoving = true;

    private void OnEnable()
    {
        p1 = transform.Find("Range1");
        p2 = transform.Find("Range2");
        p3 = transform.Find("Range3");

        p1.parent = null;
        p2.parent = null;
        p3.parent = null;
    }


    private void FixedUpdate()
    {
        if (finishedMoving)
        {
            movementNumber = Random.Range(0,3);
            finishedMoving = false;
        }

        switch ((BossPositions)movementNumber)
        {
            case BossPositions.left: //0

                if (position != BossPositions.left)
                {
                    rb2d.transform.position = Vector2.Lerp(rb2d.transform.position, p1.transform.position, boss.speedInterpolation);

                    if (rb2d.transform.position.x - p1.transform.position.x < 0.1f)
                    {
                        position = BossPositions.left;
                        finishedMoving = true;
                    }
                }
                else
                    finishedMoving = true;
                break;

            case BossPositions.center: //1
                if (position != BossPositions.center)
                {
                    rb2d.transform.position = Vector2.Lerp(rb2d.transform.position, p2.transform.position, boss.speedInterpolation);

                    if ((rb2d.transform.position.x - p2.transform.position.x > -0.1f && position == BossPositions.left) || (rb2d.transform.position.x - p2.transform.position.x < 0.1f && position == BossPositions.right))
                    {
                        position = BossPositions.center;
                        finishedMoving = true;
                    }
                }
                else
                    finishedMoving = true;
                break;

            case BossPositions.right: //2
                
                if(position != BossPositions.right)
                {
                    rb2d.transform.position = Vector2.Lerp(rb2d.transform.position, p3.transform.position, boss.speedInterpolation);

                    if(rb2d.transform.position.x - p3.transform.position.x > -0.1f)
                    {
                        position = BossPositions.right;
                        finishedMoving = true;
                    }
                }
                else
                    finishedMoving = true;
                break; 
        }
    }

    private void Update()
    {
        if (!attacking)
        {
            switch (Random.Range(0, 3))
            {
                case 0:
                    GetComponent<Attack1State_Boss1>().enabled = true;
                    attacking = true;
                    break;

                case 1:
                    GetComponent<Attack2State_Boss1>().enabled = true;
                    attacking = true;
                    break;
                    
                case 2:
                    GetComponent<Attack3State_Boss1>().enabled = true;
                    attacking = true;
                    break;
            }
        }
    }
}