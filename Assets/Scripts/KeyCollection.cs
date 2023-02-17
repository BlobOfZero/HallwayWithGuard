using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour
{
    public TextMeshProUGUI keysText;

    private void Start()
    {
        keysText = GetComponent<TextMeshProUGUI>();
        keysText.text = "Keys Collected" + keys;
    }

    private int keys = 0;
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            keys++;
            Debug.Log("keys:" +keys);
        }
    }
}
