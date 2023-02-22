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

    private int currentMail;
    private int currentKeys;
    bool winState;
     public TextMeshProUGUI winText;

    public TextMeshProUGUI countText;
    public TextMeshProUGUI keysText;

    // Start is called before the first frame update
    void Start()
    {
        currentMail = 3;
        winState = false;
        currentKeys = 0;
        winText.gameObject.SetActive(false);
        countText.text = "Mail Left: " + currentMail;
        keysText.text = "Key Collected: " + currentKeys;
    }

    private void Update()
    {
        if(currentKeys == 1 && currentMail == 0)
        {
            winState = true;
            winText.gameObject.SetActive(true);
        }
        
        if(Input.GetKeyDown(KeyCode.R) && winState == true)
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
            
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
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
