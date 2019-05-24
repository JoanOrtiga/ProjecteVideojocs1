using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public Boss1Model boss1_model;
    public PlayerModel playerModel;
    public EnemyModel exempleEnemy1; //Desde el enemy accedeixes amb GameManager.instance.exempleEnemy1;  /// Exemple al player.

    public EnemyModel trunkModel;
    public EnemyModel spiderModel;
    public EnemyModel batModel;
    public EnemyModel skeletonModel;
    public EnemyModel swampModel;
    public EnemyModel vampireModel;
    public EnemyModel devil1Model;
    public EnemyModel devil2Model;
    public EnemyModel devil3Model;
    public EnemyModel warriorModel;
    public EnemyModel magicianModel;

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
