using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript1 : MonoBehaviour
{
    public Sprite SwitchOff, SwitchOn, LightOff, LightOn;
    private SpriteRenderer switchSpriteRenderer, lightSpriteRenderer;
    private bool isOn = false;

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
            switchSpriteRenderer.sprite = SwitchOn;
            lightSpriteRenderer.sprite = LightOn;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player exited the trigger zone");
            switchSpriteRenderer.sprite = SwitchOff;
            lightSpriteRenderer.sprite = LightOff;
        }
    }
}

