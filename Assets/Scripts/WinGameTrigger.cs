using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGameTrigger : MonoBehaviour
{
    PlayerInventory inv;

    public GameObject winImage;

    public void Start()
    {
        winImage.gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(inv.winState == true)
        {
            winImage.gameObject.SetActive(true);
        }
        else return;
    }
}
