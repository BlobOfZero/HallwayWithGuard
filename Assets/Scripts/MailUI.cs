using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MailUI : MonoBehaviour
{
    public Slider slider;

    public void setMail(int mail)
    {
        slider.value = mail;
    }
}
