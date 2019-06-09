﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public Boss1Model boss1_model;
    public PlayerModel playerModel;

    // public SkeletonModel skeletonModel;


    [HideInInspector] public float featherDmg;

    public class SaveGame
    {
        public float playerHealt;
        public PlayerInventory inv;
    }

    SaveGame saveGame = new SaveGame();

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if(instance != this)
                Destroy(gameObject);
        }

        saveGame.playerHealt = playerModel.health;
        featherDmg = playerModel.arrowDmg;

        saveGame.inv = new PlayerInventory();
    }

    public void playerGetDmg(float dmgRecieved)
    {
        saveGame.playerHealt -= dmgRecieved;
    }

    public void playerHpUp(float healtIncreased)
    {
        saveGame.playerHealt += healtIncreased;
    }

    public float getplayerHealth()
    {
        return saveGame.playerHealt;
    }

    public PlayerInventory getPlayerInv()
    {
        return saveGame.inv;
    }
}