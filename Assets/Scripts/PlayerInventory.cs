using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class PlayerInventory : MonoBehaviour
{

   public AudioClip keyPickUp;
   public AudioClip mailDelivered;

   public GameObject keyPrefab;
   public Vector3 keyPrefabLocation;
   bool keySpawned;

    private int currentMail;
    private int currentKeys;
    bool winState;
     public TextMeshProUGUI winText;

    public TextMeshProUGUI countText;
    public TextMeshProUGUI keysText;

    public GameObject winImage;

    // Start is called before the first frame update
    void Start()
    {
        currentMail = 3;
        winState = false;
        currentKeys = 0;
        winText.gameObject.SetActive(false);
        countText.text = "Mail Left: " + currentMail;
        keysText.text = "Key Collected: " + currentKeys;

        winImage.gameObject.SetActive(false);
    }

    private void Update()
    {
        if(currentKeys == 1 && currentMail == 0)
        {
            winState = true;
            winText.gameObject.SetActive(true);
            winImage.gameObject.SetActive(true);
        }
        
        if(Input.GetKeyDown(KeyCode.R) && winState == true)
        {
            SceneManager.LoadScene("MainMenu");
            
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }

        if(currentMail == 0 && !keySpawned)
        {
            GameObject newObject = Instantiate(keyPrefab, keyPrefabLocation, Quaternion.identity) as GameObject; // Instantiate the object
            newObject.transform.localScale = new Vector3(20, 20, 20); // Change objects local scale
            Debug.Log("Key spawned");
            keySpawned = true;
        }
    }

  private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mail")) 
        {
            currentMail--;
            other.gameObject.SetActive(false);
            countText.text = "Mail left: " + currentMail;
            Debug.Log("mail delivered: " + currentMail);
        }

        if(other.gameObject.CompareTag("Key"))
        {
            currentKeys++;
            other.gameObject.SetActive(false);
            Debug.Log("key Collected");
            keysText.text = "Key collected: " + currentKeys;
        }
    }
}
