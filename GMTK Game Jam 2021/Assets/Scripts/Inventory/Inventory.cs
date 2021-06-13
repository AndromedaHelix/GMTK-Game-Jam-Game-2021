using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Inventory : MonoBehaviour
{
    Collider2D collisionVar;

    public TMP_Text numberText;

    int currentTextNumber;
    int numberOfKeys;

    private void Start()
    {
        numberText.text = "0";
    }

    private void Update()
    {
        if(collisionVar != null)
        {
            var PickedObject = collisionVar.GetComponent<Key>();
            if(PickedObject != null)
            {
                collisionVar.gameObject.transform.parent = transform;
                collisionVar.transform.localPosition = new Vector3(0f, 0f, 0f);
                collisionVar.gameObject.SetActive(false);
                numberOfKeys++;
                currentTextNumber = Int32.Parse(numberText.text);
                numberOfKeys += currentTextNumber;
                numberText.text = numberOfKeys.ToString();

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collisionVar = collision;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collisionVar = null;
    }
}
