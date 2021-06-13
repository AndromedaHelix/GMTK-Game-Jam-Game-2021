using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class KeyDoor : MonoBehaviour
{
    public Animator animator;

    int isOpenHash;

    public TMP_Text numberText;

    int currentNumber;

    bool hasCollided;

    private void Start()
    {
        isOpenHash = Animator.StringToHash("isOpened");
    }

    void Update()
    {
        currentNumber = Int32.Parse(numberText.text);

        if(currentNumber >= 2 && hasCollided)
        {
            animator.SetBool(isOpenHash, true);
        }
        else
        {
            animator.SetBool(isOpenHash, false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hasCollided = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hasCollided = false;
    }
}
