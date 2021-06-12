using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator animator;

    int isOpenHash;

    public bool isPressed;

    private void Start()
    {
        isOpenHash = Animator.StringToHash("isOpened");
    }

    private void Update()
    {
        if(isPressed)
        {
            animator.SetBool(isOpenHash, true);
        }
        else if(!isPressed)
        {
            animator.SetBool(isOpenHash, false);
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
