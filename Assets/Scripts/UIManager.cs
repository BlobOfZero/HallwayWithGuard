using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MailCollectible : MonoBehaviour
{
    private int mailCount;
    public TextMeshProUGUI mailText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
      if(gameObject.tag == "Mail")
      {
        mailCount++;
      }  
    }
}
