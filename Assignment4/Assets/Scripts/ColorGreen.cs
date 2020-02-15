using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorGreen : Character
{
    public ColorGreen()
    {
        this.charDescription = "Green";
    }

    public override float GetHealth()
    {
        return 3;
    }

    public override float GetSpeed()
    {
        return 5;
    }

    public override float GetDamage()
    {
        return 5;
    }
}