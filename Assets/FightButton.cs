using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FightButton : MonoBehaviour
{
    public GameObject attack1;
    public GameObject attack2;
    public GameObject attack3;
    public GameObject attack4;

    public void ShowText(String text){
        if (attack1 != null){
            attack1.SetActive(true);
        }
        if (attack2 != null)
        {
            attack2.SetActive(true);
        }
        if (attack3 != null)
        {
            attack3.SetActive(true);
        }
        if (attack4 != null)
        {
            attack4.SetActive(true);
        }
    }
}
