using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttrCreationManager : MonoBehaviour {

    PlayerCreationManager playerManager;
    PlayerPersona Player;

    [Header("Vida e Mana")]
    public Text qntLife;
    public Text qntMana;

    [Header("Atributos")]
    public Text forceValue;
    public Text dexValue;
    public Text intValue;

    // Use this for initialization
    void Start () {
        playerManager = GetComponent<PlayerCreationManager>();
        Player = playerManager.PlayerAux;
        Player.lvlpoints = 10;
        ShowAttributes();
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
        Player.ChangeAttrs();
        ShowAttributes();
    }

    public void ShowAttributes()
    {
        forceValue.text = playerManager.PlayerAux.myAttributes.strength.ToString();
        dexValue.text = playerManager.PlayerAux.myAttributes.dexterity.ToString();
        intValue.text = playerManager.PlayerAux.myAttributes.intelligence.ToString();
        playerManager.txtQntPnts.text = playerManager.PlayerAux.lvlpoints.ToString();
        qntMana.text = playerManager.PlayerAux.myStats.MAX_manaPoints.ToString();
        qntLife.text = playerManager.PlayerAux.myStats.MAX_healthPoints.ToString();
    }

}
