using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaPotion : Item
{
    private float ManaRegenerado;

    public override void use()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        ManaRegenerado = 10;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
