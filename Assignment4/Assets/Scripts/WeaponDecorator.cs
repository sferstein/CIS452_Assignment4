using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponDecorator : Character
{
    public override abstract string GetWeapDescription();

    public override abstract float GetDamage();
}
