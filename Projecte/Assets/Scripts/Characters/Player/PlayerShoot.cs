using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerShoot : PlayerState
{
    private int ammunitionAtTheTime = 5;
    private float timePast = 0;
    private float rechargeTimePowerUpPast = 30f;
    public float powerUpTime;

    private AudioSource sourceShoot;
   

    private float powerUpTimePast = 0;

    private bool PowerUpActive = false;

    public Image[] feathers;

    public Image PUFeatherActive;
    public Image PUFeatherNotActive;
    public Image PUFeatherAvailable;

    private void Start()
    {
        powerUpTime = 5;
        rechargeTimePowerUpPast = 0;
        rechargeTimePowerUpPast = 30;

        PUFeatherAvailable.enabled = true;
        PUFeatherNotActive.enabled = true;
        PUFeatherActive.enabled = false;
    }
    // Update is called once per frame
    void Update ()
    {
        Aim();
        Reacharge();
        fatherUI();
        PowerUpFeather();
    }


    private void PowerUpFeather()
    {
        rechargeTimePowerUpPast = rechargeTimePowerUpPast + Time.deltaTime;
        powerUpTimePast = powerUpTimePast + Time.deltaTime;

        if (Input.GetButton("PowerUp1") && rechargeTimePowerUpPast >= playerModel.rechargeTimePower && !GameManager.instance.paused)
        {
            powerUpTimePast = 0;
            rechargeTimePowerUpPast = 0;
            PUFeatherActive.enabled = true;
            PowerUpActive = true;
            GameManager.instance.featherDmg = playerModel.featherPowered;

            source.PlayOneShot(playerModel.powerUpSound);
        }

        if (powerUpTimePast >= powerUpTime)
        {
            if (rechargeTimePowerUpPast>= playerModel.rechargeTimePower)
            {
                PUFeatherAvailable.enabled = true;
                PUFeatherNotActive.enabled = false;
            }
            else 
            {
                PUFeatherActive.enabled = false;
                PUFeatherAvailable.enabled = false;
                PUFeatherNotActive.enabled = true;

                PowerUpActive = false;
            }

            GameManager.instance.featherDmg = playerModel.arrowDmg;
        }
    }

    private void Aim()
    {
        Vector3 mausepostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 shootingDirection = new Vector2(mausepostion.x, mausepostion.y);
        shootingDirection = shootingDirection - (Vector2)transform.position;
        shootingDirection.Normalize();


        if (Input.GetButtonDown("fireArrow") && ammunitionAtTheTime > 0 && !GameManager.instance.paused)
        {
            
            source.PlayOneShot(playerModel.shootSound);
            ammunitionAtTheTime = ammunitionAtTheTime - 1;
            if (PowerUpActive == true)
            {

                GameObject arrowPowerUp = Instantiate(playerModel.ArrowPowerUpPrefab, transform.position, Quaternion.identity);
                arrowPowerUp.GetComponent<Rigidbody2D>().velocity = shootingDirection * playerModel.shootVelocity;
                arrowPowerUp.transform.Rotate(0.0f, 0.0f, Mathf.Atan2(shootingDirection.y, shootingDirection.x) * Mathf.Rad2Deg);
                Destroy(arrowPowerUp, 2.0f);
            }
            else
            {
                GameObject arrow = Instantiate(playerModel.ArrowPrefab, transform.position, Quaternion.identity);
                arrow.GetComponent<Rigidbody2D>().velocity = shootingDirection * playerModel.shootVelocity;
                arrow.transform.Rotate(0.0f, 0.0f, Mathf.Atan2(shootingDirection.y, shootingDirection.x) * Mathf.Rad2Deg);
                Destroy(arrow, 2.0f);
            }
           
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
