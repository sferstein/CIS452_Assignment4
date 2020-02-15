using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBlue : Character
{
    public ColorBlue()
    {
        this.charDescription = "Blue";
    }

    public override float GetHealth()
    {
        return 2;
    }

    public override float GetSpeed()
    {
        return 8;
    }

    public override float GetDamage()
    {
        return 5;
    }
}
