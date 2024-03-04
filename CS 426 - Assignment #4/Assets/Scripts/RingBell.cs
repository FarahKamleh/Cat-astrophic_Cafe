using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingBell : MonoBehaviour
{
    // bell ring audio
    public AudioSource bell;

    // customer game objects
    public GameObject cust1;
    public GameObject cust2;

    // detect collision
    void OnCollisionEnter(Collision collision)
    {
        // if the bell has collided with the player
        if (collision.gameObject.tag == "BananaCat")
        {
            // make ring sound
            bell.Play();

            // turn on gravity to make customers fall from the sky
            cust1.GetComponent<Rigidbody>().useGravity = true;
            cust2.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
