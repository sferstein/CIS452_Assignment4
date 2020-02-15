using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
