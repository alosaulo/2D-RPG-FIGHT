using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttrCreationManager : MonoBehaviour {

    PlayerCreationManager playerManager;
    PlayerPersona Player;


	// Use this for initialization
	void Start () {
        playerManager = GetComponent<PlayerCreationManager>();
        Player = playerManager.Player;
        Player.lvlpoints = 10;
        playerManager.ShowAttributes();
    }

    public void SetAttr(string value)
    {
        switch (value)
        {
            case "DOWNFOR":
                if (Player.myAttributes.strength > 0)
                {
                    Player.lvlpoints += 1;
                    Player.myAttributes.strength -= 1;
                }
                break;
            case "UPFOR":
                if (Player.lvlpoints > 0)
                {
                    Player.lvlpoints -= 1;
                    Player.myAttributes.strength += 1;
                }
                break;
            case "DOWNINT":
                if (Player.myAttributes.intelligence > 0)
                {
                    Player.lvlpoints += 1;
                    Player.myAttributes.intelligence -= 1;
                }
                break;
            case "UPINT":
                if (Player.lvlpoints > 0)
                {
                    Player.lvlpoints -= 1;
                    Player.myAttributes.intelligence += 1;
                }
                break;
            case "DOWNDEX":
                if (Player.myAttributes.dexterity > 0)
                {
                    Player.lvlpoints += 1;
                    Player.myAttributes.dexterity -= 1;
                }
                break;
            case "UPDEX":
                if (Player.lvlpoints > 0)
                {
                    Player.lvlpoints -= 1;
                    Player.myAttributes.dexterity += 1;
                }
                break;
        }
        playerManager.ShowAttributes();
    }
}
