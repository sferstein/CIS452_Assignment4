using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * WeaponDecorator.cs
 * Assignment 4
 * This is the decorator class for the observer pattern.
 */

public abstract class WeaponDecorator : Character
{
    public override abstract string GetWeapDescription();

    public override abstract float GetDamage();
}
