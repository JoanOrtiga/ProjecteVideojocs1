using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySkeleton : CharacterState
{
    public string enemyName;
    public int baseAttack;
    public float moveSpeed;
    public float healthOnDeath;


    private Rigidbody2D myRigidbody;
    private  Transform target;
    public float chaseRadius;
    public float attackRedius;
    private Transform homePosition;
    private Animator anim;

    private void Awake()
    {
        base.health = 100f;
        base.initialHealth = 100f;
    }

    private void OnDestroy()
    {
        GameManager.instance.playerHpUp(healthOnDeath);
    }

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
        target = GameObject.FindWithTag("Player").transform;
        myRigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        ChechDistance();
	}

    void ChechDistance()
    {
        if (Vector3.Distance(target.position, transform.position) <= chaseRadius && Vector3.Distance(target.position, transform.position) > attackRedius )
        {
            Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            myRigidbody.MovePosition(temp);
            changeAnim(temp - transform.position);
           
            anim.SetBool("walking", true);
        }
        if (Vector3.Distance(target.position, transform.position) < attackRedius)
        {
            target.GetComponent<PlayerState>().getDmg(20 * Time.deltaTime);
            anim.SetBool("attaking", true);
        }
        else if (!(Vector3.Distance(target.position, transform.position) < attackRedius))
        {
            anim.SetBool("attaking", false);
        }
        if (Vector3.Distance(target.position, transform.position) > chaseRadius)
        {
            anim.SetBool("walking", false);
        }
        
    }


    private void SetAnimFloat(Vector2 setVector)
    {
        anim.SetFloat("moveX", setVector.x);
        anim.SetFloat("moveY", setVector.y);
    }

    private void changeAnim(Vector2 direction)
    {
        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
        {
            if (direction.x > 0)
            {
                SetAnimFloat(Vector2.right);
            }
            else if (direction.x < 0)
            {
                SetAnimFloat(Vector2.left);
            }

        }
        else if (Mathf.Abs(direction.x) < Mathf.Abs(direction.y))
        {
            if (direction.y > 0)
            {
                SetAnimFloat(Vector2.up);
            }
            else if (direction.y < 0)
            {
                SetAnimFloat(Vector2.down);
            }
        }
        
    }


}
