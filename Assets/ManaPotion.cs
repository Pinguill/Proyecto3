using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaPotion : Item
{
    private float ManaRegenerado;

    public override float use()
    {
        return 15;
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
