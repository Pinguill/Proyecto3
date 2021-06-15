using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public int ID;
    public string type;
    public string description;
    public Sprite icon;

    [HideInInspector]
    public bool pickedUp;

    [HideInInspector]
    public GameObject Potion;


    public void itemUsage()
    {
        if( type == "Potion"){
            if( ID == 2){
                
            }
            else if(ID == 2){

            }
        }
    }

    public abstract void use();
}
