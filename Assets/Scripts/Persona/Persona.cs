using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Persona : MonoBehaviour
{

    public Races myRace;
    public Classes myClass;
    public Attributes myAttributes;
    public Stats myStats;

    [Header("Character Name")] public string charaName;
    
    [Header("Experience")]public int lvlpoints;
    
    [Header("Total Atk")]protected float ATK;
    [Header("Total Def")]protected float DEF;

    public void Recharge(Potions potion) {
        float percentage;
        if (potion.potionType == Potions.PotionType.Health)
        {
            percentage = potion.rechargeValue * myStats.MAX_healthPoints;
            myStats.healthPoints = percentage + myStats.healthPoints;
        }
        else {
            percentage = potion.rechargeValue * myStats.MAX_manaPoints;
            myStats.manaPoints = percentage + myStats.manaPoints;
        }
    }

}
