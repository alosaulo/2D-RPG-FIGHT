using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class PlayerPersona : Persona
{

    HealthManaControl myHealthManaGUI;

    [Header("Inventory")]
    public Inventory myInventory;
	
	[Header(("Gold"))]
    public double myGold;

    [Header("Player Controller")]
    public PlayerController PlayerControl;
    public int PlayerNumber;

    private void Awake()
    {
        myGold = 1000;
	    myAttributes = new Attributes();
        myAttributes.strength = 0;
        myAttributes.intelligence = 0;
        myAttributes.dexterity = 0;
    }

    public void ChangeAttrs()
    {
        string className = myClass.ClassName;
        int lifePoints = myAttributes.strength * 3;
        int manaPoints = myAttributes.intelligence * 3;
        if (className != null)
        {
            switch (className)
            {
                case ("Knight"):
                    lifePoints = Mathf.CeilToInt(lifePoints * 1.25f);
                    break;
                case ("Hunter"):

                    break;
                case ("Mage"):
                    manaPoints = Mathf.CeilToInt(manaPoints * 1.25f);
                    break;
            }
        }
        myStats.healthPoints = lifePoints;
        myStats.MAX_healthPoints = lifePoints;
        myStats.manaPoints = manaPoints;
        myStats.MAX_manaPoints = manaPoints;
    }

    public void SetPlayerPersona(PlayerPersona player)
    {
        this.myAttributes = player.myAttributes;
        this.myClass = player.myClass;
        this.myRace = player.myRace;
        this.myStats = player.myStats;
    }

    // Use this for initialization
    void Start () {
        PlayerControl = GetComponent<PlayerController>();
    }

    void OnEnable()
    {
        
    }

    public void CheckSceneStats() {
        if (GameSceneManager._instance != null && PlayerManager._instance != null)
        {
            if (GameSceneManager._instance.ActualScene.name.Equals(SceneTags.PlayScene))
            {
                PlayerManager._instance.Players.Add(gameObject);
                myHealthManaGUI = PlayerManager._instance.healthManaControl;
                ShowMyStats();
            }
        }
    }

    void ShowMyStats() {
        if(myHealthManaGUI != null) { 
            myHealthManaGUI.SetHealth(myStats.healthPoints, myStats.MAX_healthPoints, PlayerNumber);
            myHealthManaGUI.SetMana(myStats.manaPoints, myStats.MAX_manaPoints, PlayerNumber);
        }
    }

    // Update is called once per frame
	void Update () {
        
	}
}
