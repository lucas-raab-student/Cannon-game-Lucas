using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float forceAmount = 15.0f;
    public GameObject explsionPrefab;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Vector3 forceDirection = transform.forward;

        rigidbody.AddForce(forceDirection * forceAmount, ForceMode.VelocityChange);
    }
    void OnCollisionEnter(Collision other)
    {
        print("collides with " + other.gameObject.name);
        if (other.gameObject.CompareTag("tower"))
        {
            // Insateiat the explsion prefab at prjecitlle postion
            Instantiate(explsionPrefab, transform.position, Quaternion.identity);
            //destory projectile
            Destroy(gameObject);
        }
    }
    // Update is caeled once per frame
    void Update()
    {
        
    }

}
