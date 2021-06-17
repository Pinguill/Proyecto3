using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPotion : Item
{
    private float vidaCurada;
    // Start is called before the first frame update
    private void Start()
    {
        vidaCurada = 10;
    }

    // Update is called once per frame
    private void Update()
    {

    }

    public void usePotion()
    {

    }

    public override float use()
    {
        return 10;
    }
}
