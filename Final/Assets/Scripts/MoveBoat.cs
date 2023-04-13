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
    void Update()
    {
        if(switchHit.on == true)
        {
            var step = -transform.right.normalized * 2  * Time.fixedDeltaTime;
            rigidbody.MovePosition(transform.position + step);
        }
    }
}
