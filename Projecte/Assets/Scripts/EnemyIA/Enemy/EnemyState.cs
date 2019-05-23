using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyStates
{
    patrol, chase, attack
}

public class EnemyState : CharacterState
{
    protected EnemyModel enemy;

    protected Rigidbody2D rb2D;

    protected Animator atorSke;

    protected PlayerStates currentState;

    protected Collider2D patrolArea;



    public enum EnemyType
    {
        Trunk,
        Spider,
        Bat,
        Skeleton,
        Swamp,
        Vampire,
        Devil1,
        Devil2,
        Devil3,
        Warrior,
        Magician
    };

    public EnemyType _enemyType;

    override public void InitState()
    {

        switch (_enemyType)
        {
            case EnemyType.Trunk:
                enemy = GameManager.instance.trunkModel;
                break;
            case EnemyType.Spider:
                enemy = GameManager.instance.spiderModel;
                break;
            case EnemyType.Bat:
                enemy = GameManager.instance.batModel;
                break;
            case EnemyType.Skeleton:
                enemy = GameManager.instance.skeletonModel;
                break;
            case EnemyType.Swamp:
                enemy = GameManager.instance.swampModel;
                break;
            case EnemyType.Vampire:
                enemy = GameManager.instance.vampireModel;
                break;
            case EnemyType.Devil1:
                enemy = GameManager.instance.devil1Model;
                break;
            case EnemyType.Devil2:
                enemy = GameManager.instance.devil2Model;
                break;
            case EnemyType.Devil3:
                enemy = GameManager.instance.devil3Model;
                break;
            case EnemyType.Warrior:
                enemy = GameManager.instance.warriorModel;
                break;
            case EnemyType.Magician:
                enemy = GameManager.instance.magicianModel;
                break;
            default:
                break;
        }

        enemy.enemyHealth = enemy._health;

        rb2D = GetComponent<Rigidbody2D>();
        rb2D.isKinematic = true;

        atorSke = GetComponent<Animator>();
        patrolArea = GetComponent<Collider2D>();

        patrolArea.isTrigger = true;
    }
}
