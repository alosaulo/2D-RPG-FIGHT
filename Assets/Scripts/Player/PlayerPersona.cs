using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class PlayerPersona : Persona
{

    public PlayerController PlayerControl;

	[Header("Inventory")]
    public Inventory myInventory;
	
	[Header(("Gold"))]
    public double myGold;

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
        myStats.SetMaxLifePoints(lifePoints);
        myStats.SetActualLifePoints(lifePoints);
        myStats.SetMaxManaPoints(manaPoints);
        myStats.SetActualManaPoints(manaPoints);
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
        PlayerControl = GetComponent<PlayerController>();;
    }

	// Update is called once per frame
	void Update () {

	}
}
