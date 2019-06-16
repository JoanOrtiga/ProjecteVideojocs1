using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwampEnemie : CharacterState
{
    public string enemyName;
    public int baseAttack;
    public float moveSpeed;
    public float healthOnDeath;
    public GameObject ball;
    public float shootPeriod = 1f;
    public float rotationSpeed = 40f;

    private Transform spawnPoint;


    private Rigidbody2D myRigidbody;
    private Transform target;
    public float chaseRadius;
    public float attackRedius;
    public float throwRadius;
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
    void Start()
    {
        anim = GetComponent<Animator>();
        target = GameObject.FindWithTag("Player").transform;
        myRigidbody = GetComponent<Rigidbody2D>();
        spawnPoint = transform.Find("SpawnPoint");
    }

    // Update is called once per frame
    void Update()
    {
        ChechDistance();

        Vector2 ctoP = target.position - transform.position;

        Quaternion rot = Quaternion.LookRotation(transform.forward, ctoP);
        spawnPoint.transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, rotationSpeed * Time.deltaTime);

    }

    void ChechDistance()
    {
        if (Vector3.Distance(target.position, transform.position) <= chaseRadius
            && Vector3.Distance(target.position, transform.position) > attackRedius
            && Vector3.Distance(target.position, transform.position) < throwRadius)
        {
            Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
            myRigidbody.MovePosition(temp);
            changeAnim(temp - transform.position);
            anim.SetBool("walking", true);
            Debug.Log("walk true");
        }
        if (Vector3.Distance(target.position, transform.position) < attackRedius)
        {
            Debug.Log("attak true");
            target.GetComponent<PlayerState>().getDmg(20 * Time.deltaTime);
            anim.SetBool("attaking", true);
        }
        else if (!(Vector3.Distance(target.position, transform.position) < attackRedius))
        {
            anim.SetBool("attaking", false);
        }
        if (!(Vector3.Distance(target.position, transform.position) <= chaseRadius
            && Vector3.Distance(target.position, transform.position) > attackRedius
            && Vector3.Distance(target.position, transform.position) < throwRadius))
        {
            anim.SetBool("walking", false);
        }
        if (Vector3.Distance(target.position, transform.position) > chaseRadius && Vector3.Distance(target.position, transform.position) < throwRadius)
        {
            Debug.Log("Throw true");
            Shoot();
            anim.SetBool("throwing", true);
        }

    }





    private void SetAnimFloat(Vector2 setVector)
    {
        anim.SetFloat("moveX", setVector.x);
        anim.SetFloat("moveY", setVector.y);
    }


    private void Shoot()
    {
        Instantiate(ball, spawnPoint.position, transform.rotation);
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
