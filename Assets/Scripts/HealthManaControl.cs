using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManaControl : MonoBehaviour
{
    public List<HealthMana> HealthManas;

    public void SetMana(int value, int maxValue, int playerNum)
    {
        HealthMana myHM = HealthManas[playerNum];
        myHM.ManaText.text = value.ToString();
        myHM.ManaImage.fillAmount = value / maxValue;
    }

    public void SetHealth(int value, int maxValue, int playerNum)
    {
        HealthMana myHM = HealthManas[playerNum];
        myHM.HealthText.text = value.ToString();
        myHM.HealthImage.fillAmount = value / maxValue;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
