using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  Enemies : MonoBehaviour
{
    private float vida;
    private float attack;

    public abstract float getVida();
    public abstract float getAttack();
}
