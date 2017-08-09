using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerPersona : Persona {

    public Inventory myInventory;

    public double myGold;

    [Header("Race Stats")]
    public int RaceINT;
    public int RaceDEX;
    public int RaceSTR;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        myGold = 1000;
	    myAttributes = new Attributes();
        myAttributes.strength = 0;
        myAttributes.intelligence = 0;
        myAttributes.dexterity = 0;
    }

    // Use this for initialization
    void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
