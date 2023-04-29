using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeBarrels : MonoBehaviour
{
    public Object Rocks;

    public AudioSource Explosion;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {   Destroy(Rocks,2);
            Destroy(this.gameObject,1);
            Debug.Log("reload");
            Explosion.Play();
        }
    }

}
