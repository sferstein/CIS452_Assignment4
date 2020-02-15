using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
