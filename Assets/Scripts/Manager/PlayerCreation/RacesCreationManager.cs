using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacesCreationManager : MonoBehaviour {

    PlayerCreationManager playerManager;
    PlayerPersona Player;

    private void Start()
    {
        playerManager = GetComponent<PlayerCreationManager>();
        Player = playerManager.Player;
    }

    public void SetPlayerHuman()
    {
        Player.myRace = new Human();
        playerManager.ShowRaceSkills();
    }

    public void SetPlayerElf()
    {
        Player.myRace = new Elf();
        playerManager.ShowRaceSkills();
    }

    public void SetPlayerDwarf()
    {
        Player.myRace = new Dwarf();
        playerManager.ShowRaceSkills();
    }
}
