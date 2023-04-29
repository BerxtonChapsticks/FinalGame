using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI HealthNum;


    [SerializeField] private SwitchControl switchControl;

    float force = 1000f; // the force with which the player is pushed back when they collide with something

    public Rigidbody shipRigidbody;

    public bool isCollidingWithRocks = false;
    
    void Start()
    {
        shipRigidbody = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        if (isCollidingWithRocks)
        {
            //ShipTakeDmg(20);
            //Debug.Log(GameManager.gameManger.shipHealth.Health);

            // calculate the direction in which to push back the player
            //Vector3 pushForceDirection = transform.position - other.transform.position;
            //pushForceDirection.Normalize();

            // apply the push force to the player

            //shipRigidbody.AddForce(-transform.forward, ForceMode.Impulse);
        }

        //HealthNum.text = "Health : " + GameManager.gameManger.shipHealth.Health;


        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShipTakeDmg(1);
            Debug.Log(GameManager.gameManger.shipHealth.Health);
        }
    }

    private void ShipTakeDmg(int dmg)
    {
        GameManager.gameManger.shipHealth.DmgUnit(dmg);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Rocks"))
        {
            switchControl.switchHit = true;
            isCollidingWithRocks = true;

            ShipTakeDmg(20);
            Debug.Log(GameManager.gameManger.shipHealth.Health);
            // ShipTakeDmg(20);
            // Debug.Log(GameManager.gameManger.shipHealth.Health);

            // // calculate the direction i transform.position - other.transform.position;
            // pushForceDirection.Normalizn which to push back the player
            // Vector3 pushForceDirection =e();

            // // apply the push force to the player
            // shipRigidbody.AddForce(-transform.forward * pushForce, ForceMode.Impulse);
            

        }
    //Debug.Log(other);
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Rocks"))
        {
            isCollidingWithRocks = false;
        }
    }
}
