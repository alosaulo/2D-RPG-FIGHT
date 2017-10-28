using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RacesCreationManager : MonoBehaviour {

    PlayerCreationManager playerManager;
    PlayerPersona Player;

    [Header("Características Raciais")]
    public Text txtHabRaces;
    public Text forceModValue;
    public Text dexModValue;
    public Text intModValue;

    private void Start()
    {
        playerManager = GetComponent<PlayerCreationManager>();
        Player = playerManager.PlayerAux;
    }

    public void SetPlayerHuman()
    {
        Player.myRace = new Human();
        ShowRaceSkills();
    }

    public void SetPlayerElf()
    {
        Player.myRace = new Elf();
        ShowRaceSkills();
    }

    public void SetPlayerOrc()
    {
        Player.myRace = new Orc();
        ShowRaceSkills();
    }

    public void ShowRaceSkills()
    {
        txtHabRaces.text = "";
        if (playerManager.PlayerAux.myRace != null)
        {
            txtHabRaces.text = playerManager.PlayerAux.myRace.RaceDescription;
            forceModValue.text = playerManager.PlayerAux.myRace.modFOR.ToString();
            dexModValue.text = playerManager.PlayerAux.myRace.modDEX.ToString();
            intModValue.text = playerManager.PlayerAux.myRace.modINT.ToString();
            playerManager.ChangePlayerSprite();
        }
    }
}
