using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchControl : MonoBehaviour
{
    public bool on = false;
    public bool switchHit = false;

    private float switchRotation = 100;
    private GameObject switchBase;

    // Start is called before the first frame update
    void Start()
    {
        switchBase = transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (switchHit == true)
        {
            switchHit = false;
            //if on is true make on false, and if on is false make on true
            on = !on;

            //rotate
            if (on == true)
            {
                transform.rotation = Quaternion.Euler(transform.eulerAngles.x + switchRotation, transform.eulerAngles.y, transform.eulerAngles.z);
            }
            else
            {
                transform.rotation = Quaternion.Euler(transform.eulerAngles.x - switchRotation, transform.eulerAngles.y, transform.eulerAngles.z);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerHand"))
        {
            switchHit = true;
        }
    }
}
