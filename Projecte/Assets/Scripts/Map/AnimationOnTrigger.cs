using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOnTrigger : MonoBehaviour {


    public Renderer rendererGameObject;
    public BoxCollider2D boxColliderGameObject;

    private void Awake()
    {
        rendererGameObject = GetComponent<Renderer>();
        boxColliderGameObject = GetComponent<BoxCollider2D>();
    }
    private void Start()
    {
        rendererGameObject.enabled = false;
        boxColliderGameObject.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Debug.Log("TRONCO");
            rendererGameObject.enabled = true;
            boxColliderGameObject.enabled = true;
        }
        
    }
}
