using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada : Item
{
    private float attack;
    private float durability;

    public override void use()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        attack = 4;
        durability = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
