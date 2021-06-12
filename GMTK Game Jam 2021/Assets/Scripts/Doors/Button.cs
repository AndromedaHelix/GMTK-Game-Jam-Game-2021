using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public bool isPressed;

    public BoxCollider2D boxCollider2D;

    private void Update()
    {
        if(isPressed)
        {
            boxCollider2D.enabled = false;
            Debug.Log("oppened");
        }
        else if(!isPressed)
        {
            boxCollider2D.enabled = true;
            Debug.Log("Closed");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPressed = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isPressed = false;
    }
}
