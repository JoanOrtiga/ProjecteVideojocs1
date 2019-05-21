using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Boss1State))]
public class MovingState_Boss1 : Boss1State
{
    private enum Positions
    {
        left, center, right
    }

    private Positions position = Positions.center;

    private int movementNumber;
    private bool finishedMoving = true;
    
    private void FixedUpdate()
    {
        if (finishedMoving)
        {
            movementNumber = Random.Range(0,3);
            finishedMoving = false;
        }

        switch ((Positions)movementNumber)
        {
            case Positions.left: //0

                if (position != Positions.left)
                {
                    rb2d.transform.position = Vector2.Lerp(rb2d.transform.position, p1.transform.position, boss.speedInterpolation);

                    if (rb2d.transform.position.x - p1.transform.position.x < 0.1f)
                    {
                        position = Positions.left;
                        finishedMoving = true;
                    }
                }
                else
                    finishedMoving = true;
                break;

            case Positions.center: //1
                if (position != Positions.center)
                {
                    rb2d.transform.position = Vector2.Lerp(rb2d.transform.position, p2.transform.position, boss.speedInterpolation);

                    if ((rb2d.transform.position.x - p2.transform.position.x > -0.1f && position == Positions.left) || (rb2d.transform.position.x - p2.transform.position.x < 0.1f && position == Positions.right))
                    {
                        position = Positions.center;
                        finishedMoving = true;
                    }
                }
                else
                    finishedMoving = true;
                break;

            case Positions.right: //2
                
                if(position != Positions.right)
                {
                    rb2d.transform.position = Vector2.Lerp(rb2d.transform.position, p3.transform.position, boss.speedInterpolation);

                    if(rb2d.transform.position.x - p3.transform.position.x > -0.1f)
                    {
                        position = Positions.right;
                        finishedMoving = true;
                    }
                }
                else
                    finishedMoving = true;
                break;
               
        }

        if (!attacking)
        {
            switch (Random.Range(0, 4))
            {
                case 0:
                    attacking = true;
                    GetComponent<Attack1State_Boss1>().enabled = true;
                    break;
            }
        }
        
    }

    public void attackingFalse()
    {
        attacking = false;
    }
}