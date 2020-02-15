using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * WeaponPistol.cs
 * Assignment 4
 * This is one of the concrete decorators used in the observer pattern.
 */

public class WeaponPistol : WeaponDecorator
{
    Character character;

    public WeaponPistol(Character character)
    {
        this.character = character;
    }

    public override string GetWeapDescription()
    {
        return character.GetWeapDescription() + "Pistol";
    }

    public override float GetDamage()
    {
        return character.GetDamage() + 1;
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
