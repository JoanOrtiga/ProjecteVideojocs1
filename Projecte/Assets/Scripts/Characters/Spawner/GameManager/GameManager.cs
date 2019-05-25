﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public Boss1Model boss1_model;
    public PlayerModel playerModel;
  
   // public SkeletonModel skeletonModel;

    public class SaveGame
    {
        public float playerHealt;
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
    }

    public void playerGetDmg(float dmgRecieved)
    {
        saveGame.playerHealt -= dmgRecieved;
        print("Player: " + saveGame.playerHealt);
    }

    public void playerHpUp(float healtIncreased)
    {
        saveGame.playerHealt += healtIncreased;
    }
}
