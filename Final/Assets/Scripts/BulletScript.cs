using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DeleteMe", 20);
    }

    void DeleteMe()
    {
        Destroy(gameObject);
    }
    
}
