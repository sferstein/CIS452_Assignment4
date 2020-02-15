using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Sam Ferstein
 * TitleScreen.cs
 * Assignment 4
 * This class controls the title screen and the buttons that make it progress.
 */

public class TitleScreen : MonoBehaviour
{
    public GameObject tutorialScreen;
    public GameObject characterScreen;
    public GameObject weaponScreen;
    public GameObject characterGreen;
    public GameObject characterBlue;
    public GameObject weaponPistol;
    public GameObject weaponRail;

    void Start()
    {
        characterGreen.gameObject.SetActive(false);
        characterBlue.gameObject.SetActive(false);
        weaponPistol.gameObject.SetActive(false);
        weaponRail.gameObject.SetActive(false);
    }

    public void characterSelect()
    {
        tutorialScreen.gameObject.SetActive(false);
        characterScreen.gameObject.SetActive(true);
        characterBlue.gameObject.SetActive(true);
        characterGreen.gameObject.SetActive(true);
    }

    public void weaponSelect()
    {
        characterScreen.gameObject.SetActive(false);
        characterBlue.gameObject.SetActive(false);
        characterGreen.gameObject.SetActive(false);
        weaponScreen.gameObject.SetActive(true);
        weaponPistol.gameObject.SetActive(true);
        weaponRail.gameObject.SetActive(true);
    }

    public void startGame()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }
}
