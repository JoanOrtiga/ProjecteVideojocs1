using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class PlayerShoot : MonoBehaviour
{

    public GameObject arrowPrefab;
    public float shootVelocety = 50;
    public float totalAmmunition = 5;
    protected float ammunitionAtTheTime = 5;
    public float timeToRecharge = 3;
    private float timePast = 0;

    public Image feather1, feather2, feather3, feather4, feather5;


    void Start ()
    {
   
    }
	
	// Update is called once per frame
	void Update ()
    {
        Aim();
        Reacharge();
        fatherUI();
    }


    private void Aim()
    {
        Vector3 mausepostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 shootingDirection = new Vector2(mausepostion.x, mausepostion.y);
        shootingDirection = shootingDirection - (Vector2)transform.position;
        shootingDirection.Normalize();
       

        if (Input.GetButtonDown("fireArrow") && ammunitionAtTheTime > 0)
        {
            ammunitionAtTheTime = ammunitionAtTheTime - 1;

           // Debug.Log(Input.mousePosition.x + Input.mousePosition.y);
            GameObject arrow = Instantiate(arrowPrefab, transform.position, Quaternion.identity);
            arrow.GetComponent<Rigidbody2D>().velocity = shootingDirection * shootVelocety;

            arrow.transform.Rotate(0.0f, 0.0f, Mathf.Atan2(shootingDirection.y, shootingDirection.x) * Mathf.Rad2Deg);
            Destroy(arrow, 2.0f);
        }
       
    }
    private void Reacharge()
    {
        timePast = Time.deltaTime + timePast;
        if (ammunitionAtTheTime == 5)
        {
            timePast = 0;
        }
        if (timePast > timeToRecharge && ammunitionAtTheTime != 5)
        {
            ammunitionAtTheTime = ammunitionAtTheTime + 1;
            timePast = 0;
        }
    }




    private void fatherUI()
    {
        if (ammunitionAtTheTime == 5)
        {

            feather1.enabled = true;
            feather2.enabled = true;
            feather3.enabled = true;
            feather4.enabled = true;
            feather5.enabled = true;
           

        }
        else if (ammunitionAtTheTime == 4)
        {
            feather1.enabled = true;
            feather2.enabled = true;
            feather3.enabled = true;
            feather4.enabled = true;
            feather5.enabled = false;
           
        }
        else if (ammunitionAtTheTime == 3)
        {
            feather1.enabled = true;
            feather2.enabled = true;
            feather3.enabled = true;
            feather4.enabled = false;
            feather5.enabled = false;
           
        }
        else if (ammunitionAtTheTime == 2)
        {

            feather1.enabled = true;
            feather2.enabled = true;
            feather3.enabled = false;
            feather4.enabled = false;
            feather5.enabled = false;
            
        }
        else if (ammunitionAtTheTime == 1)
        {
            feather1.enabled = true;
            feather2.enabled = false;
            feather3.enabled = false;
            feather4.enabled = false;
            feather5.enabled = false;
           
        }
        else if (ammunitionAtTheTime == 0)
        {
            feather1.enabled = false;
            feather2.enabled = false;
            feather3.enabled = false;
            feather4.enabled = false;
            feather5.enabled = false;
            
        }
    }
}
