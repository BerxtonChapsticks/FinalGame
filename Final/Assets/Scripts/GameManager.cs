using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManger {get; private set;}

    public UnitHealth shipHealth = new UnitHealth(100, 100);
    
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


