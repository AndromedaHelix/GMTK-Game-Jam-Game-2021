using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoButton : MonoBehaviour
{
    public bool isPressed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPressed = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isPressed = false;
    }
}
