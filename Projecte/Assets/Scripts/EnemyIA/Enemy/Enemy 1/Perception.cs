using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perception : MonoBehaviour
{

    [Range(0.5f, 10f)] public float rangeVision = 2f;
    [Range(0, 1)] public float FOV = 0.5f;
    public LayerMask playerLayer;
    public float timeToPerception = 0.2f;
    [HideInInspector] public Transform target;


    private float FOVangle;
    private float cosFOVangle;
    // Use this for initialization
    void Start()
    {
        target = null;

        FOVangle = Mathf.Lerp(0, 180, FOV);
        cosFOVangle = Mathf.Cos(FOVangle * 0.5f * Mathf.Deg2Rad);

        InvokeRepeating("PerceptionService", 0.1f, timeToPerception);

    }

    private void PerceptionService()
    {
        Collider2D col = Physics2D.OverlapCircle(transform.position, rangeVision, playerLayer.value);
        if (col == null)
        {
            target = null;
            return;
        }
        Vector2 etoP = col.gameObject.transform.position - transform.position;
        etoP.Normalize();
        float currentCosFOV = Vector2.Dot(etoP, -transform.up);
        if (currentCosFOV < cosFOVangle)
        {
            target = null;
            return;
        }

        int restOfLayers = ~(1 << gameObject.layer); //máscara de bit de la capa de este objeto
        RaycastHit2D hit = Physics2D.Raycast(transform.position, etoP, rangeVision, restOfLayers);
        if (hit.collider.gameObject.tag == "Player")
        {
            target = hit.collider.gameObject.transform;
            return;
        }

        target = null;
    }

    private void OnDrawGizmos()
    {
        FOVangle = Mathf.Lerp(0, 180, FOV);


        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, rangeVision);
        Gizmos.color = Color.red;




        Vector3 fovVector = -transform.up * rangeVision;

        Quaternion rot = Quaternion.AngleAxis(FOVangle * 0.5f, Vector3.forward);
        Vector3 p1 = transform.position + rot * fovVector;
        Quaternion rot2 = Quaternion.AngleAxis(-FOVangle * 0.5f, Vector3.forward);
        Vector3 p2 = transform.position + rot2 * fovVector;

        Gizmos.DrawLine(transform.position, p1);
        Gizmos.DrawLine(transform.position, p2);
    }
}

