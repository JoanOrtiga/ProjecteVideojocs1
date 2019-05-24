using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public Boss1Model boss1_model;
    public PlayerModel playerModel;

    
    public SkeletonModel skeletonModel;

    /*
    public TrunkModel trunkModel;
    public SpiderModel spiderModel;
    public BatModel batModel;
    public SwampModel swampModel;
    public VampireModel vampireModel;
    public Devil1Model devil1Model;
    public Devil2Model devil2Model;
    public Devil3Model devil3Model;
    public WarriorModel warriorModel;
    public MagicianModel magicianModel;*/

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
    }

    public void playerGetDmg(float dmgRecieved)
    {
        saveGame.playerHealt -= dmgRecieved;
        print(saveGame.playerHealt);
    }

    public void playerHpUp(float healtIncreased)
    {
        saveGame.playerHealt += healtIncreased;
    }
}
