using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class PlayerPersona : Persona {
	
	[Header("Inventory")]
    public Inventory myInventory;
	
	[Header(("Gold"))]
    public double myGold;

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
