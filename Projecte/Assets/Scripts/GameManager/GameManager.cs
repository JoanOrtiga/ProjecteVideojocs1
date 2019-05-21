using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    // public EnemyModel doorGuardianModel;
    // public PlayerModel pModel;
    // public InventoryController inv;

    public Boss1_Model boss1_model;

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

    private void Start()
    {
     //   inv = new InventoryController();
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
