using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

[System.Serializable]
public class PlayerCreationManager : MonoBehaviour
{

    public List<StartCharacters> CharacterSpritesDic;

    public PlayerPersona PlayerAux;

    public GameObject PlayerSpawn;

    public GameObject PnlWarning;

    public Text txtQntPnts;

    public Image imagePersona; 
    
    void Start () {
        
	}

    public void ChangePlayerSprite() {
        if (PlayerAux.myRace.RaceName != "")
        {
            if (PlayerAux.myClass.ClassName != "")
            {
                imagePersona.color = new Color(1, 1, 1, 1);
                string job = PlayerAux.GetJobAndRaceNames();
                Sprite spriteAux = null;
                foreach (StartCharacters character in CharacterSpritesDic)
                {
                    if (character.myName == job) {
                        spriteAux = character.mySprite;
                        break;
                    }
                }
                imagePersona.sprite = spriteAux;
            }
        }
    }

    public void SetPlayer()
    {
        string playerResourceName = "Player";
        playerResourceName += PlayerAux.GetJobAndRaceNames();
        GameObject PlayerObject = Resources.Load(playerResourceName) as GameObject;
        GameObject PlayerGameObject = Instantiate(PlayerObject, PlayerSpawn.transform.position, Quaternion.identity);
        PlayerGameObject.GetComponent<PlayerPersona>().SetPlayerPersona(PlayerAux);
        PlayerGameObject.GetComponent<PlayerController>().Speed = PlayerAux.myAttributes.dexterity * 1000;
    }

}
