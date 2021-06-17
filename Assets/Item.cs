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
    player jugador;


    public void itemUsage()
    {
        if( type == "Potion"){
            if( ID == 2){
                healthPotion healthP = new healthPotion();
                float vidaRepuesta = healthP.use();
                jugador.curarse( vidaRepuesta );
                
            }
        }else if (type == "Weapon"){
            Espada espadaP = new Espada();
            float danioExtra = espadaP.use();
            jugador.danioExtra( danioExtra );
        }
    }

    public abstract float use();
}
