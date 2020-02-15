using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * ColorBlue.cs
 * Assignment 4
 * This is one of the concrete components that directly effects the character's stats.
 */

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
