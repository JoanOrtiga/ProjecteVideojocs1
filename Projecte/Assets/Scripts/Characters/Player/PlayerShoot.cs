using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerShoot : PlayerState
{
    private int ammunitionAtTheTime = 5;
    private float timePast = 0;

    public Image[] feathers;

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

            GameObject arrow = Instantiate(playerModel.ArrowPrefab, transform.position, Quaternion.identity);
            arrow.GetComponent<Rigidbody2D>().velocity = shootingDirection * playerModel.shootVelocity;

            arrow.transform.Rotate(0.0f, 0.0f, Mathf.Atan2(shootingDirection.y, shootingDirection.x) * Mathf.Rad2Deg);
            Destroy(arrow, 2.0f);
        }     
    }

    private void Reacharge()
    {
        timePast = Time.deltaTime + timePast;
        if (ammunitionAtTheTime == playerModel.maximumAmunition)
        {
            timePast = 0;
        }
        if (timePast > playerModel.timeToRecharge && ammunitionAtTheTime != playerModel.maximumAmunition)
        {
            ammunitionAtTheTime = ammunitionAtTheTime + 1;
            timePast = 0;
        }
    }

    private void fatherUI()
    {
        switch (ammunitionAtTheTime)
        {
            case 5:
                feathers[4].enabled = true;
                break;
            case 4:
                feathers[3].enabled = true;
                feathers[4].enabled = false;
                break;
            case 3:
                feathers[2].enabled = true;
                feathers[3].enabled = false;
                break;
            case 2:
                feathers[1].enabled = true;
                feathers[2].enabled = false;
                break;
            case 1:
                feathers[0].enabled = true;
                feathers[1].enabled = false;
                break;
            case 0:
                feathers[0].enabled = false;
                break;
        }
    }


}
