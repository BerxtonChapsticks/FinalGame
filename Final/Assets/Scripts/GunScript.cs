using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR;

public class GunScript : MonoBehaviour
{

    public Rigidbody bullet;
    public float bulletSpeed = 40.0f;
    public int magSize = 1;
    [Header("Higher reload speed means slower charge")]
    public float reloadSpeed = 1.0f;
    public float reloadDelay = 1.0f;
    //public Transform batteryMeter;
    public AudioSource fireSound;
    public AudioSource reloadSound;
    //private Vector3 batteryMeterScale;
    private int rounds = 0;
    private bool recharging = false;
    private InputDevice xrController;
    private HapticCapabilities hapcap;

    // Start is called before the first frame update
    void Start()
    {
        rounds = magSize;
        //batteryMeterScale = batteryMeter.localScale;
        
        xrController = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        Debug.Log(xrController);
        Debug.Log("XRCONTROLLER");
        Debug.Log(xrController.isValid);
        if (xrController.isValid)
        {
            hapcap = new HapticCapabilities();
            xrController.TryGetHapticCapabilities(out hapcap);
            Debug.Log("hapcap");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Fire()
    {
        if (rounds >= 1 )
        {
            Rigidbody bulletClone = (Rigidbody) Instantiate(bullet, transform.position, transform.rotation);
            bulletClone.velocity = bulletClone.transform.up * bulletSpeed;
            rounds--;
            //SetBatteryMeter();
            Debug.Log(rounds);
            fireSound.Play();
        }
    }

    public void Reload()
    {
        if (rounds < magSize)
        {
            Debug.Log("reload");
            rounds++;
            Debug.Log(rounds);
            //SetBatteryMeter();
            reloadSound.Play();
        }
    }

    /*public void StartRecharge()
    {
        Debug.Log("start recharge");
        InvokeRepeating(nameof(Reload), reloadDelay, reloadSpeed);
        recharging = true;

        if (hapcap.supportsImpulse)
        {
            xrController.SendHapticImpulse(0, 0.5f);
        }        
    }
    
    public void StopRecharge()
    {
        Debug.Log("stop recharge");
        CancelInvoke(nameof(Reload));
        recharging = false;
    }
    
    /*void SetBatteryMeter()
    {
        batteryMeterScale.x = Map(rounds, 0, magSize, 0, 18); // 18 is the x scale of the battery capacity game object
        batteryMeter.localScale = batteryMeterScale;
    }*/
    
    private static float Map(float value, float fromLow, float fromHigh, float toLow, float toHigh) 
    {
        return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
    }
}
