using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwitchScript : MonoBehaviour
{
    public Sprite SwitchOff, SwitchOn, LightOff, LightOn;
    private SpriteRenderer switchSpriteRenderer, lightSpriteRenderer;
    private bool isOn = false;
    private bool insideTrigger = false;

    private void Start()
    {
        switchSpriteRenderer = GetComponent<SpriteRenderer>();
        lightSpriteRenderer = transform.Find("Light").GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player entered the trigger zone");
            insideTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player exited the trigger zone");
            insideTrigger = false;
        }
    }

    private void Update()
    {
        if (insideTrigger && Input.GetKeyDown(KeyCode.Space))
        {
            isOn = !isOn;
            if (isOn)
            {
                switchSpriteRenderer.sprite = SwitchOn;
                lightSpriteRenderer.sprite = LightOn;
                Debug.Log("Switch and light turned on");
            }
            else
            {
                switchSpriteRenderer.sprite = SwitchOff;
                lightSpriteRenderer.sprite = LightOff;
                Debug.Log("Switch and light turned off");
            }
        }
    }
}




