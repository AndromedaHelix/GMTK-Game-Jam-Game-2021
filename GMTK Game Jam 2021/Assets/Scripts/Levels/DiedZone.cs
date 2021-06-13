using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiedZone : MonoBehaviour
{
    public GameObject diedMenu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        diedMenu.SetActive(true);
    }
}
