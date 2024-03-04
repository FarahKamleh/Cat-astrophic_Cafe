using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingBell : MonoBehaviour
{
    public AudioSource bell;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // detect collision
    void OnCollisionEnter(Collision collision)
    {
        // if the bell has collided with the player
        if (collision.gameObject.tag == "BananaCat")
        {
            // make ring sound
            bell.Play();
        }
    }
}
