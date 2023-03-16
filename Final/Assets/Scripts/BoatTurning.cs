using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatTurning : MonoBehaviour
{

    //Wheels/objects to controll whith wheel
    public GameObject Vehicle;
    private Rigidbody VehicleRigidBody;

    public float currentSteeringWheelRotation = 0;

    private float turnDampening = 9999;

    // Start is called before the first frame update
    void Start()
    {
        VehicleRigidBody = Vehicle.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        TurnVehicle();

        currentSteeringWheelRotation = -transform.rotation.eulerAngles.z;
    }

    private void TurnVehicle()
    {
        //Turns Wheels compared to the steering wheel
        var turn = -transform.rotation.eulerAngles.z;
        if(turn < -350)
        {
            turn = turn + 360;
        }
        
        VehicleRigidBody.MoveRotation(Quaternion.RotateTowards(Vehicle.transform.rotation, Quaternion.Euler(0, turn, 0), Time.deltaTime * turnDampening));
    }
}
