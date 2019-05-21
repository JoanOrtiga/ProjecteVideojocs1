using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
    {
    public float speed = 4;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    private Animator animatior;

    // Start is called before the first frame update
    void Start()
    {
        animatior = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero; //reset 
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        UpdateAnimationaAndMove();
       
    }

    void UpdateAnimationaAndMove()
    {
        if (change != Vector3.zero)
        {
            MoveCharacter();
            animatior.SetFloat("moveX", change.x);
            animatior.SetFloat("moveY", change.y);
            animatior.SetBool("moving", true);
        }
        else
        {
            animatior.SetBool("moving", false);
        }

    }

    void MoveCharacter()
    {
        myRigidbody.MovePosition( transform.position + change * speed * Time.deltaTime);
    }
}
