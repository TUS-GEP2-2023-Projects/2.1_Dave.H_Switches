using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchActivator : MonoBehaviour
{
    public GameObject switchObject;
    public LayerMask playerLayer;
  
    public float raycastDistance = 5f;

    private GameObject playerGO;

    private void Start()
    {
        playerGO = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        bool playerInZone = false;
        Vector2 directionOfPlayer = Vector3.Normalize(PlayerPosition() - transform.position);

        Debug.DrawRay(transform.position, directionOfPlayer * raycastDistance, Color.green);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, directionOfPlayer, raycastDistance, playerLayer);
        if (hit.collider)
        {
            Debug.Log("Hit something");
            if(hit.collider.CompareTag("Player"))
            {
                playerInZone = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && playerInZone)
        {
            Debug.Log("Turn on the bulb");
            //Write code to turn on bulb;
        }

    }
    Vector3 PlayerPosition()
    {
        return playerGO.transform.position;
    }

}

