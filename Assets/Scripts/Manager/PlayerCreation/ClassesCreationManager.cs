using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClassesCreationManager : MonoBehaviour {

    PlayerCreationManager playerManager;
    PlayerPersona Player;

    [Header("Habilidades")]
    public Text txtHabClasses;
    public Text txtMainSkill1;
    public Text txtMainSkill2;
    public Text txtSkill1;
    public Text txtSkill2;
    

    // Use this for initialization
    void Start () {
        playerManager = GetComponent<PlayerCreationManager>();
        Player = playerManager.PlayerAux;
	}

    public void SetPlayerWarrior()
    {
        Player.myClass = new Knight();
        ShowClassSkills();
    }

    public void SetPlayerMage()
    {
        Player.myClass = new Mage();
        ShowClassSkills();
    }

    public void SetPlayerHunter()
    {
        Player.myClass = new Hunter();
        ShowClassSkills();
    }

    public void ShowClassSkills()
    {
        txtHabClasses.text = "";
        txtSkill1.text = "";
        txtSkill2.text = "";
        if (playerManager.PlayerAux.myClass != null)
        {
            txtHabClasses.text = playerManager.PlayerAux.myClass.ClassDescription;
            txtMainSkill1.text = playerManager.PlayerAux.myClass.skills[0].skillName;
            txtMainSkill2.text = playerManager.PlayerAux.myClass.skills[1].skillName;
            txtSkill1.text = playerManager.PlayerAux.myClass.skills[0].description;
            txtSkill2.text = playerManager.PlayerAux.myClass.skills[1].description;
            playerManager.ChangeMainPlayer();
        }
    }

}
