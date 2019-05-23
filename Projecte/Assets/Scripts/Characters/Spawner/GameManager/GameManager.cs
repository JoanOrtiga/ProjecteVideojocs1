using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public Boss1Model boss1_model;
    public PlayerModel playerModel;
    public EnemyModel exempleEnemy1; //Desde el enemy accedeixes amb GameManager.instance.exempleEnemy1;  /// Exemple al player.

    public TrunkModel trunkModel;
    public SpiderModel spiderModel;
    public BatModel batModel;
    public SkeletonModel skeletonModel;
    public SwampModel swampModel;
    public VampireModel vampireModel;
    public Devil1Model devil1Model;
    public Devil2Model devil2Model;
    public Devil3Model devil3Model;
    public WarriorModel warriorModel;
    public MagicianModel magicianModel;

    public class SaveGame
    {
        //aqui dins van totes les variables que s'han de guardar entre nivells
        //quan el profe ho pengi completo.
    }

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
}
