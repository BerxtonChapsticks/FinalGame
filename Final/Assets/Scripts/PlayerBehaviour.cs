using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShipTakeDmg(20);
            Debug.Log(GameManager.gameManger.shipHealth.Health);
        }
    }

    private void ShipTakeDmg(int dmg)
    {
        GameManager.gameManger.shipHealth.DmgUnit(dmg);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Rocks")
        {
            ShipTakeDmg(20);
            Debug.Log(GameManager.gameManger.shipHealth.Health);
        }
        Debug.Log("asshole");
    }
}
