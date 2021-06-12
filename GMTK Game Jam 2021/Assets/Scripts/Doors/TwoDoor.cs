using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDoor : MonoBehaviour
{
    public Animator animator;

    int isOpenHash;

    public TwoButton button1;
    public TwoButton button2;

    public bool isPressed1;
    public bool isPressed2;

    private void Start()
    {
        isOpenHash = Animator.StringToHash("isOpened");
    }

    private void Update()
    {
        isPressed1 = button1.isPressed;
        isPressed2 = button2.isPressed;


        if (isPressed1 && isPressed2)
        {
            animator.SetBool(isOpenHash, true);
        }
    }
}
