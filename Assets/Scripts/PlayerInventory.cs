using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInventory : MonoBehaviour
{
    public TextMeshProUGUI winText;
    private int currentMail;
    private int currentKeys;
    bool winState;

    public TextMeshProUGUI countText;
    // Start is called before the first frame update
    void Start()
    {
        currentMail = 3;
        winState = false;
        currentKeys = 0;
        winText.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(currentKeys == 1 && currentMail == 0)
        {
            winState = true;
            winText.gameObject.SetActive(true);

        }
    }

  private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mail")) 
        {
            currentMail--;
            other.gameObject.SetActive(false);
            Debug.Log("mail delivered" + currentMail);
        }

        if(other.gameObject.CompareTag("Key"))
        {
            currentKeys++;
            other.gameObject.SetActive(false);
            Debug.Log("key Collected");
        }
        }
    }
