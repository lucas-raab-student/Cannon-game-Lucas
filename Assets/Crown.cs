using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crown : MonoBehaviour
{
    public GameObject explosion;

    void Start()
    {
    }

    [System.Obsolete]
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the "Plane" tag
        if (collision.gameObject.CompareTag("Plane"))
        {
            // Find the Score component in the scene
            Score score = FindObjectOfType<Score>();

            if (score)
            {
                // Call EndLevel() on the Score script
                score.EndLevel();
            }
            else
            {
                // Debug log if the Score component is not found
                Debug.LogWarning("Score component not found in the scene!");
            }
        }
    }

    void Update()
    {
    }
}
