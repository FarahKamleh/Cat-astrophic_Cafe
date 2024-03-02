using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// adding namespaces
using Unity.Netcode;

// because we are using the NetworkBehaviour class
// NewtorkBehaviour class is a part of the Unity.Netcode namespace
// extension of MonoBehaviour that has functions related to multiplayer
public class PlayerMovement : NetworkBehaviour
{
    // EDIT: adding rotation and movement
    public float speed = 0.1f;
    public float rotationSpeed = 90;
    public float force = 700f;

    // reference to the camera audio listener
    [SerializeField] private AudioListener audioListener;
    // reference to the camera
    [SerializeField] private Camera playerCamera;

    Rigidbody rb;
    Transform t;
    private GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody>();
        // t = GetComponent<Transform>();d
    }

    // Update is called once per frame
    void Update()
    {
        // check if the player is the owner of the object
        // makes sure the script is only executed on the owners 
        // not on the other prefabs 
        if (!IsOwner) return;

        Vector3 moveDirection = new Vector3(0, 0, 0);

        // EDIT: because of rotation, make sure players have opposing controls
        if ((int)OwnerClientId > 0)
        {
            if (Input.GetKey(KeyCode.W))
            {
                moveDirection.x = +1f;
            }
            if (Input.GetKey(KeyCode.S))
            {
                moveDirection.x = -1f;
            }
            if (Input.GetKey(KeyCode.A))
            {
                moveDirection.z = +1f;
            }
            if (Input.GetKey(KeyCode.D))
            {
                moveDirection.z = -1f;
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                moveDirection.x = -1f;
            }
            if (Input.GetKey(KeyCode.S))
            {
                moveDirection.x = +1f;
            }
            if (Input.GetKey(KeyCode.A))
            {
                moveDirection.z = -1f;
            }
            if (Input.GetKey(KeyCode.D))
            {
                moveDirection.z = +1f;
            }
        }

        transform.position += moveDirection * speed * Time.deltaTime;


        // Time.deltaTime represents the time that passed since the last frame
        //the multiplication below ensures that GameObject moves constant speed every frame
        // if (Input.GetKey(KeyCode.W))
        //     rb.velocity += this.transform.forward * speed * Time.deltaTime;
        // else if (Input.GetKey(KeyCode.S))
        //     rb.velocity -= this.transform.forward * speed * Time.deltaTime;

        // // Quaternion returns a rotation that rotates x degrees around the x axis and so on
        // if (Input.GetKey(KeyCode.D))
        //     t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
        // else if (Input.GetKey(KeyCode.A))
        //     t.rotation *= Quaternion.Euler(0, - rotationSpeed * Time.deltaTime, 0);
        
        // if (Input.GetKeyDown(KeyCode.Space))
        //     rb.AddForce(t.up * force);
    }

    // this method is called when the object is spawned
    // we will change the color of the objects
    public override void OnNetworkSpawn()
    {
        // check if the player is the owner of the object
        if (!IsOwner) return;
        // if the player is the owner of the object
        // enable the camera and the audio listener
        audioListener.enabled = true;
        playerCamera.enabled = true;

        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();

        // EDIT: for the client spawn point
        if ((int)OwnerClientId > 0)
        {
            spawnPoint = GameObject.Find("Client Spawnpoint");
            transform.position = spawnPoint.transform.position;
            transform.rotation = spawnPoint.transform.rotation;
        }
        // EDIT: for the host spawn point
        else
        {
            spawnPoint = GameObject.Find("Host Spawnpoint");
            transform.position = spawnPoint.transform.position;
            transform.rotation = spawnPoint.transform.rotation;
        }
    }
}