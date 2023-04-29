using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBoat : MonoBehaviour
{
    private Rigidbody rigidbody;
    public SwitchControl switchHit;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(switchHit.on == true)
        {
            var step = -transform.right.normalized * 3  * Time.fixedDeltaTime;
            rigidbody.MovePosition(transform.position + step);
        }
    }
}
