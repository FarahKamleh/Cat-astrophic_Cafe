using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class FridgeScript : NetworkBehaviour
{
    // EDIT: specify the camera
    Camera following;

    // EDIT: score holder
    public Score scoreManager;

    // EDIT: ingredients in hand
    public GameObject iceCream;
    public GameObject cherry;
    public GameObject milk;
    public GameObject banana;

    // EDIT: at the start, no ingredient clicked
    bool selected = false;

    // EDIT: ensure only one item in basket
    bool inside1 = false;
    bool inside2 = false;
    bool inside3 = false;
    bool inside4 = false;

    // EDIT: carried object bools
    bool carryIceCream = false;
    bool carryMilk = false;
    bool carryCherry = false;
    bool carryBanana = false;

    // EDIT: ingredients in baskets
    public GameObject bIceCream3;
    public GameObject bMilk4;
    public GameObject bCherry2;
    public GameObject bBanana1;

    // EDIT: finished orders
    public GameObject smoothie;
    public GameObject sundae;

    // EDIT: to prevent duplicates
    int bananaCount = 0;
    int milkCount = 0;
    int cherryCount = 0;
    int bananaCount2 = 0;
    int iceCreamCount2 = 0;
    int cherryCount2 = 0;

    // EDIT: turn basket lights on and off
    public Light leftLight;
    public Light rightLight;

    // EDIT: temp variables to destroy the lights
    Light tempLeftLight;
    Light tempRightLight;

    // Start is called before the first frame update
    void Start()
    {
        // EDIT: get the camera component
        following = GetComponent<Camera>();

        // EDIT: hand ingredients inactive at start
        iceCream.SetActive(false);
        cherry.SetActive(false);
        milk.SetActive(false);
        banana.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // EDIT: check for a mouse click
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit raycastHit;
            Ray ray = following.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.transform != null)
                {
                    Debug.Log(raycastHit.transform.gameObject.tag);
                    ClickedObject(raycastHit.collider);
                }
            }
        }
        
    }

    // EDIT: a function to check which gameobject was selected
    public void ClickedObject(Collider collider)
    {
        // EDIT: check which game object is selected and destroy it; ensure only one at a time
        if (collider.CompareTag("IceCream"))
        {
            // EDIT: bool to ensure one item at a time
            if (selected == false)
            {
                // EDIT: destroy the game object
                Destroy(collider.gameObject);

                // EDIT: make the ice cream of player appear
                iceCream.SetActive(true);

                // EDIT: change selected to true
                selected = true;

                // EDIT: change inside to false
                inside3 = false;

                // EDIT: mark which game object is being carried
                carryIceCream = true;
            }
        }
        if (collider.CompareTag("Cherry"))
        {
            // EDIT: bool to ensure one item at a time
            if (selected == false)
            {
                // EDIT: destroy the game object
                Destroy(collider.gameObject);

                // EDIT: make the ice cream of player appear
                cherry.SetActive(true);

                // EDIT: change selected to true
                selected = true;

                // EDIT: mark which being carried
                carryCherry = true;

                // EDIT: change inside to false
                inside2 = false;
            }
        }
        if (collider.CompareTag("Milk"))
        {
            // EDIT: bool to ensure one item at a time
            if (selected == false)
            {
                // EDIT: destroy the game object
                Destroy(collider.gameObject);

                // EDIT: make the ice cream of player appear
                milk.SetActive(true);

                // EDIT: change selected to true
                selected = true;

                // EDIT: mark which being carried
                carryMilk = true;

                // EDIT: change inside to false
                inside4 = false;
            }
        }
        if (collider.CompareTag("Banana"))
        {
            // EDIT: bool to ensure one item at a time
            if (selected == false)
            {
                // EDIT: destroy the game object
                Destroy(collider.gameObject);

                // EDIT: make the ice cream of player appear
                banana.SetActive(true);

                // EDIT: change selected to true
                selected = true;

                // EDIT: mark which being carried
                carryBanana = true;

                // EDIT: change inside to false
                inside1 = false;
            }
        }
        // -----------------------------------------------------------------------

        // EDIT: for adding to baskets
        if (collider.CompareTag("Basket3"))
        {
            // if carrying object and nothing inside, add object
            if (selected == true && inside3 == false)
            {
                // EDIT: only
                if (carryIceCream == true)
                {
                    // EDIT: switch which are active
                    Instantiate(bIceCream3, new Vector3(-0.7f, 0.927f, -0.751f), Quaternion.identity);
                    iceCream.SetActive(false);

                    // EDIT: mark that something is inside
                    inside3 = true;

                    // EDIT: selected now false
                    selected = false;
                }
            }
        }

        if (collider.CompareTag("Basket4"))
        {
            // if carrying object and nothing inside, add object
            if (selected == true && inside4 == false)
            {
                // EDIT: only
                if (carryMilk == true)
                {
                    // EDIT: switch which are active
                    Instantiate(bMilk4, new Vector3(-2.01f, 0.927f, 0.013f), Quaternion.identity);
                    milk.SetActive(false);

                    // EDIT: mark that something is inside
                    inside4 = true;

                    // EDIT: selected now false
                    selected = false;
                }
            }
        }

        if (collider.CompareTag("Basket2"))
        {
            // if carrying object and nothing inside, add object
            if (selected == true && inside2 == false)
            {
                // EDIT: only
                if (carryCherry == true)
                {
                    // EDIT: switch which are active
                    Instantiate(bCherry2, new Vector3(0.703f, 0.927f, -0.448f), Quaternion.identity);
                    cherry.SetActive(false);

                    // EDIT: mark that something is inside
                    inside2 = true;

                    // EDIT: selected now false
                    selected = false;
                }
            }
        }

        if (collider.CompareTag("Basket1"))
        {
            // if carrying object and nothing inside, add object
            if (selected == true && inside1 == false)
            {
                // EDIT: only
                if (carryBanana == true)
                {
                    // EDIT: switch which are active
                    Instantiate(bBanana1, new Vector3(2.01f, 1.006f, -0.37f), Quaternion.identity);
                    banana.SetActive(false);

                    // EDIT: mark that something is inside
                    inside1 = true;

                    // EDIT: selected now false
                    selected = false;
                }
            }
        }

        // ---------------------------------------------------------------------------
        // EDIT: deal with deliveries
        if (collider.CompareTag("Delivery 1"))
        {
            if (selected == true)
            {
                // EDIT: only
                if (carryBanana == true && bananaCount == 0)
                {
                    Debug.Log("In Banana");
                    // EDIT: switch which are active
                    banana.SetActive(false);

                    // EDIT: count the number
                    bananaCount = 1;

                    // EDIT: selected now false
                    selected = false;
                }
                if (carryCherry == true && cherryCount == 0)
                {
                    Debug.Log("In Cherry");
                    // EDIT: switch which are active
                    cherry.SetActive(false);

                    // EDIT: count the number
                    cherryCount = 1;

                    // EDIT: selected now false
                    selected = false;
                }
                if (carryMilk == true && milkCount == 0)
                {
                    Debug.Log("In Milk");
                    Debug.Log("entered");
                    // EDIT: switch which are active
                    milk.SetActive(false);
                    
                    // EDIT: count the number
                    milkCount = 1;

                    // EDIT: selected now false
                    selected = false;
                }
            }
            // EDIT: if an order has been finished, add to the score
            if (bananaCount == 1 && milkCount == 1 && cherryCount == 1)
            {
                // scoreManager.AddPoint();
                Debug.Log("In Smoothie");
                Debug.Log(bananaCount);

                // EDIT: reset the counts
                bananaCount = 0;
                milkCount = 0;
                cherryCount = 0;
                carryBanana = false;
                carryMilk = false;
                carryCherry = false;
                Debug.Log(bananaCount);
                // EDIT: instantiate a smoothie
                Debug.Log("smoothie");
                Instantiate(smoothie, new Vector3(-3.462f, 0.783f, 4.5f), Quaternion.identity);
                // EDIT: make the left light turn on through instantiation with correct rotation
                tempLeftLight = Instantiate(leftLight, new Vector3(-3.462f, 3.245f, 4.495f), Quaternion.Euler(90, 0, 0));
            }
        }


        // EDIT: deal with deliveries
        if (collider.CompareTag("Delivery 2"))
        {
            if (selected == true)
            {
                // EDIT: only
                if (carryBanana == true && bananaCount2 == 0)
                {
                    // EDIT: switch which are active
                    banana.SetActive(false);

                    // EDIT: count the number
                    bananaCount2 = 1;

                    // EDIT: selected now false
                    selected = false;
                }
                if (carryCherry == true && cherryCount2 == 0)
                {
                    // EDIT: switch which are active
                    cherry.SetActive(false);

                    // EDIT: count the number
                    cherryCount2 = 1;

                    // EDIT: selected now false
                    selected = false;
                }
                if (carryIceCream == true && iceCreamCount2 == 0)
                {
                    /// EDIT: switch which are active
                    iceCream.SetActive(false);

                    // EDIT: count the number
                    iceCreamCount2 = 1;

                    // EDIT: selected now false
                    selected = false;
                }
            }

            // EDIT: if an order has been finished, add to the score
            if (bananaCount2 == 1 && iceCreamCount2 == 1 && cherryCount2 == 1)
            {
                // scoreManager.AddPoint();

                // EDIT: reset the counts
                bananaCount2 = 0;
                iceCreamCount2 = 0;
                cherryCount2 = 0;
                carryBanana = false;
                carryIceCream = false;
                carryCherry = false;

                // EDIT: instantiate a sundae
                Debug.Log("sundae");
                Instantiate(sundae, new Vector3(3.54f, 0.94f, -5.471f), Quaternion.identity);
                // EDIT: make the right light turn on through instantiation with correct rotation
                tempRightLight = Instantiate(rightLight, new Vector3(3.6f, 3.268f, -5.459f), Quaternion.Euler(90, 0, 0));
            }
        }

        // -----------------------------------------------------------------------------------------
        // EDIT: this is backup code if the spawning/networking doesnt work
        if (collider.CompareTag("BananaLabel"))
        {
            Instantiate(bBanana1, new Vector3(2.01f, 1.006f, -0.37f), Quaternion.identity);
        }
        if (collider.CompareTag("MilkLabel"))
        {
            Instantiate(bMilk4, new Vector3(-2.01f, 0.927f, 0.013f), Quaternion.identity);
        }
        if (collider.CompareTag("IceCreamLabel"))
        {
            Instantiate(bIceCream3, new Vector3(-0.7f, 0.927f, -0.751f), Quaternion.identity);
        }
        if (collider.CompareTag("CherryLabel"))
        {
            Instantiate(bCherry2, new Vector3(0.703f, 0.927f, -0.448f), Quaternion.identity);
        }

        // EDIT: to rid of the sundaes and smoothies
        if (collider.CompareTag("Sundae"))
        {
            Destroy(collider.gameObject);
            Destroy(tempRightLight);
        }
        if (collider.CompareTag("Smoothie"))
        {
            Destroy(collider.gameObject);
            Destroy(tempLeftLight);
        }

    }
}