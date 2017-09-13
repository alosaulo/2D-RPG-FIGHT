using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassesCreationManager : MonoBehaviour {

    PlayerCreationManager playerManager;
    PlayerPersona Player;

    // Use this for initialization
    void Start () {
        playerManager = GetComponent<PlayerCreationManager>();
        Player = playerManager.PlayerAux;
	}

    public void SetPlayerWarrior()
    {
        Player.myClass = new Knight();
        playerManager.ShowClassSkills();
    }

    public void SetPlayerMage()
    {
        Player.myClass = new Mage();
        playerManager.ShowClassSkills();
    }

    public void SetPlayerHunter()
    {
        Player.myClass = new Hunter();
        playerManager.ShowClassSkills();
    }

}
