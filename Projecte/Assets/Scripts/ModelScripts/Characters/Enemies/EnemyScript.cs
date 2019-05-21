using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private float _health;
 
    private enum EnemyType
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

    [SerializeField]
    private EnemyType _type;

    // Use this for initialization
    void Start ()
    {
        if (_type == EnemyType.Trunk)
            _health = GameManager.instance.trunkModel._health;
        else if (_type == EnemyType.Spider)
            _health = GameManager.instance.spiderModel._health;
        else if (_type == EnemyType.Bat)
            _health = GameManager.instance.batModel._health;
        else if (_type == EnemyType.Skeleton)
            _health = GameManager.instance.skeletonModel._health;
        else if (_type == EnemyType.Swamp)
            _health = GameManager.instance.swampModel._health;
        else if (_type == EnemyType.Vampire)
            _health = GameManager.instance.vampireModel._health;
        else if (_type == EnemyType.Devil1)
            _health = GameManager.instance.devil1Model._health;
        else if (_type == EnemyType.Devil2)
            _health = GameManager.instance.devil2Model._health;
        else if (_type == EnemyType.Devil3)
            _health = GameManager.instance.devil3Model._health;
        else if (_type == EnemyType.Warrior)
            _health = GameManager.instance.warriorModel._health;
        else if (_type == EnemyType.Magician)
            _health = GameManager.instance.magicianModel._health;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void SetHealth(float health)
    {
        _health += health;
    }
}
