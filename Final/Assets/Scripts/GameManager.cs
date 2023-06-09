using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI HealthNum;

    public static GameManager gameManger {get; private set;}

    public UnitHealth shipHealth = new UnitHealth(100, 100);

    void Update()
    {
        //HealthNum.text = "Health : " + currentHealth;
        if( GameManager.gameManger.shipHealth.Health <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
    
    void Awake()
    {
        if (gameManger != null && gameManger != this)
        {
            Destroy(this);
        }
        else
        {
            gameManger = this;
        }
    }
}


