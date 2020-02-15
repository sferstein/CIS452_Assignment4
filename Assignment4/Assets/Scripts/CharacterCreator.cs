using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sam Ferstein
 * CharacterCreator.cs
 * Assignment 4
 * This is the concrete component that implements the component character class.
 */

public class CharacterCreator : MonoBehaviour
{
    public Character character;
    private MeshRenderer meshRenderer;
    public GameObject barrel;
    public GameObject playerColor;
    public Material[] materials;

    public void SetColor(string newCharacter)
    {
        switch (newCharacter)
        {
            case "Blue":
                this.character = new ColorBlue();
                break;
            case "Green":
                this.character = new ColorGreen();
                break;
            default:
                Debug.LogError("No character color called " + newCharacter);
                break;
        }
    }

    public void SetWeapon(string newWeapon)
    {
        switch (newWeapon)
        {
            case "Pistol":
                this.character = new WeaponPistol(character);
                break;
            case "Railgun":
                this.character = new WeaponRail(character);
                break;
            default:
                Debug.LogError("No weapon called " + newWeapon);
                break;
        }
    }

    public void ChangeCharacter()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        if (character.GetCharDescription() == "Blue")
        {
            meshRenderer.material = materials[0];
            character.playerHealth = 2;
            character.speed = 8;
            character.GetDamage();
        }
        if (character.GetCharDescription() == "Green")
        {
            meshRenderer.material = materials[1];
            character.playerHealth = 3;
            character.speed = 5;
            character.GetDamage();
        }
        if(character.GetWeapDescription() == "Pistol")
        {
            meshRenderer.material = materials[3];
            character.GetDamage();
        }
        if (character.GetWeapDescription() == "Railgun")
        {
            meshRenderer.material = materials[0];
            character.GetDamage();
        }
    }
}
