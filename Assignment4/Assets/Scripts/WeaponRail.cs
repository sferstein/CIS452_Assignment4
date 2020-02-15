using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * WeaponRail.cs
 * Assignment 4
 * This is one of the concrete decorators used in the observer pattern.
 */

public class WeaponRail : WeaponDecorator
{
    Character character;

    public WeaponRail(Character character)
    {
        this.character = character;
    }

    public override string GetWeapDescription()
    {
        return character.GetWeapDescription() + "Railgun";
    }

    public override float GetDamage()
    {
        return character.GetDamage() + 2;
    }

    public override float GetHealth()
    {
        return character.GetHealth();
    }

    public override float GetSpeed()
    {
        return character.GetSpeed();
    }
}
