using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[System.Serializable]
public class PlayerCreationManager : MonoBehaviour
{   
    [HideInInspector]
    public GameObject PlayerGameObject;

    public PlayerPersona PlayerAux;

    public GameObject PlayerSpawn;

    public GameObject PnlWarning;
    
    [Header("Validação")]
    public ToggleGroup tglClasses;
    public ToggleGroup tglRaces;
    public Text inputText;

    [Header("Habilidades")]
    public Text txtHabRaces;
    public Text txtHabClasses;
    public Text txtMainSkill1;
    public Text txtMainSkill2;
    public Text txtSkill1;
    public Text txtSkill2;
    public Text txtQntPnts;

    [Header("Atributos")]
    public Text forceValue;
    public Text forceModValue;
    public Text dexValue;
    public Text dexModValue;
    public Text intValue;
    public Text intModValue;

    [Header("Vida e Mana")] 
    public Text qntLife;
    public Text qntMana;
    
    // Use this for initialization
    void Start () {
        
	}

    public void ShowRaceSkills() {
        txtHabRaces.text = "";
        if (PlayerAux.myRace != null)
        {
            txtHabRaces.text = PlayerAux.myRace.RaceDescription;
            forceModValue.text = PlayerAux.myRace.modFOR.ToString();
            dexModValue.text = PlayerAux.myRace.modDEX.ToString();
            intModValue.text = PlayerAux.myRace.modINT.ToString();
            ChangeMainPlayer();
        }
    }

    public void ShowClassSkills() {
        txtHabClasses.text = "";
        txtSkill1.text = "";
        txtSkill2.text = "";
        if (PlayerAux.myClass != null) {
            txtHabClasses.text = PlayerAux.myClass.ClassDescription;
            txtMainSkill1.text = PlayerAux.myClass.skills[0].skillName;
            txtMainSkill2.text = PlayerAux.myClass.skills[1].skillName;
            txtSkill1.text = PlayerAux.myClass.skills[0].description;
            txtSkill2.text = PlayerAux.myClass.skills[1].description;
            ChangeMainPlayer();
        }
    }

    public void ShowAttributes() {
        forceValue.text = PlayerAux.myAttributes.strength.ToString();
        dexValue.text = PlayerAux.myAttributes.dexterity.ToString();
        intValue.text = PlayerAux.myAttributes.intelligence.ToString();
        txtQntPnts.text = PlayerAux.lvlpoints.ToString();
        qntMana.text = PlayerAux.myStats.MAX_manaPoints.ToString();
        qntLife.text = PlayerAux.myStats.MAX_healthPoints.ToString();
    }

    public bool CheckValidation() {
        if (PlayerAux.lvlpoints > 0 || tglClasses.AnyTogglesOn() == false || tglRaces.AnyTogglesOn() == false 
            || inputText.text == "") {
            return false;
        }
        else {
            return true;
        }
    }

    public void SetPlayer()
    {
        PlayerGameObject.GetComponent<PlayerPersona>().SetPlayerPersona(PlayerAux);
        PlayerGameObject.GetComponent<PlayerController>().Speed = PlayerAux.myAttributes.dexterity * 1000;
    }

    public void ChangeMainPlayer()
    {
        string playerResourceName = "Player";
        if (PlayerGameObject != null)
        {
            Destroy(PlayerGameObject);
        }
        if (PlayerAux.myClass.ClassName != "" && PlayerAux.myRace.RaceName != "")
        {   
            playerResourceName += PlayerAux.myRace.RaceName;
            playerResourceName += PlayerAux.myClass.ClassName;
            Debug.Log(playerResourceName);
            GameObject gb = Resources.Load(playerResourceName) as GameObject;
            PlayerGameObject = Instantiate(gb, PlayerSpawn.transform.position, Quaternion.identity);
            PlayerGameObject.GetComponent<PlayerController>().Speed = 0;
        }
    }
}
