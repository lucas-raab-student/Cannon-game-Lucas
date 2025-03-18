using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explsion : MonoBehaviour
{
    public float force, raduis, modifer;
  public GameObject explosionFX;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyExplosion", 0.1f);
        Instantiate(explosionFX, transform.position, Quaternion.identity);
       
    }
    void OnTriggerEnter(Collider other)
    {
        Rigidbody rigidbody = other.GetComponent<Rigidbody>();
        if (rigidbody)
        {
            rigidbody.AddExplosionForce(force, transform.position, raduis, modifer, ForceMode.VelocityChange);
        }
    }
    void DestroyExplosion()
    {
        Destroy(gameObject);
    }
    

   
       

    // Update is called once per frame
    void Update()
    {
        
    }
}
