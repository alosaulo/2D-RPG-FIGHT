using UnityEngine;
using System.Collections;
using UnityEngine.UI;


[System.Serializable]
public class PlayerCreationManager : MonoBehaviour {

    public PlayerPersona Player;

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
    public Text qntVida;
    public Text qntMana;
    
    // Use this for initialization
    void Start () {
        
	}

    public void ShowRaceSkills() {
        txtHabRaces.text = "";
        if (Player.myRace != null)
        {
            txtHabRaces.text = Player.myRace.RaceDescription;
            forceModValue.text = Player.myRace.modFOR.ToString();
            dexModValue.text = Player.myRace.modDEX.ToString();
            intModValue.text = Player.myRace.modINT.ToString();
        }
    }

    public void ShowClassSkills() {
        txtHabClasses.text = "";
        txtSkill1.text = "";
        txtSkill2.text = "";
        if (Player.myClass != null) {
            txtHabClasses.text = Player.myClass.ClassDescription;
            txtMainSkill1.text = Player.myClass.skills[0].skillName;
            txtMainSkill2.text = Player.myClass.skills[1].skillName;
            txtSkill1.text = Player.myClass.skills[0].description;
            txtSkill2.text = Player.myClass.skills[1].description;
        }
    }

    public void ShowAttributes() {
        forceValue.text = Player.myAttributes.strength.ToString();
        dexValue.text = Player.myAttributes.dexterity.ToString();
        intValue.text = Player.myAttributes.intelligence.ToString();
        txtQntPnts.text = Player.lvlpoints.ToString();
    }

    public bool CheckValidation() {
        if (Player.lvlpoints > 0 || tglClasses.AnyTogglesOn() == false || tglRaces.AnyTogglesOn() == false 
            || inputText.text == "") {
            return false;
        }
        else {
            return true;
        }
    }

}
