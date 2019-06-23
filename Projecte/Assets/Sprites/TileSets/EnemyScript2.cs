using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript2 : MonoBehaviour
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
    
    /*
    // Use this for initialization
    void Start ()
    {
        if (_type == EnemyType.Trunk)
        {
           // _health = GameManager.instance
        }
        else if (_type == EnemyType.Spider)
        {
            
        }
        else if (_type == EnemyType.Spider)
        {

        }
        else if (_type == EnemyType.Bat)
        {

        }
        else if (_type == EnemyType.Skeleton)
        {

        }
        else if (_type == EnemyType.Swamp)
        {

        }
        else if (_type == EnemyType.Vampire)
        {

        }
        else if (_type == EnemyType.Devil1)
        {

        }
        else if (_type == EnemyType.Devil2)
        {

        }
        else if (_type == EnemyType.Devil3)
        {

        }
        else if (_type == EnemyType.Warrior)
        {

        }
        else if (_type == EnemyType.Magician)
        {

        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void SetHealth(float health)
    {
        _health += health;
    }*/
}
