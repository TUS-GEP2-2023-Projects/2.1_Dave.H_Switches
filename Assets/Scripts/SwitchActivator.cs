using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchActivator : MonoBehaviour
{
    public GameObject switchObject;
    public float raycastDistance = 5f; 
  
    
    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, PlayerPosition() - transform.position);
        RaycastHit hit;

        if (Physics.Raycast(ray,out hit, raycastDistance))
        {
            if(hit.collider.CompareTag("Player"))
            {
                if ( Input.GetKeyDown(KeyCode.Space))
                {
                    switchObject.GetComponent<Switch>(). Activate();
                }
            }
        }

    }
}

Vector3 PlayerPosition()
{
    return GameObject.FindGameObjectWithTag("Player").transform.position;
}
