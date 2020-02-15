using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * ColorGreen.cs
 * Assignment 4
 * This is one of the concrete components that directly effects the character's stats.
 */

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