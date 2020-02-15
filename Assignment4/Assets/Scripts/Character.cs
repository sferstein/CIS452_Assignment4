using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * Character.cs
 * Assignment 4
 * This is the component class that will be used by the other classes for the Observer pattern.
 */

public abstract class Character
{
    public string charDescription;
    public string weapDescription;
    public float speed;
    public float playerHealth;

    public virtual string GetCharDescription()
    {
        return charDescription;
    }

    public virtual string GetWeapDescription()
    {
        return weapDescription;
    }

    public abstract float GetHealth();

    public abstract float GetSpeed();

    public abstract float GetDamage();
}
