using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Persona : MonoBehaviour
{
    public Races myRace { get; set; }
    public Classes myClass { get; set;}
    public Attributes myAttributes { get; set;}
    public Stats myStats { get; set;}

    public string charaName {get; set;}

    public int lvlpoints { get; set; }

    protected float ATK { get; set; }
    protected float DEF { get; set; }

    public void Recharge(Potions potion) {
        float percentage;
        if (potion.potionType == Potions.PotionType.Health)
        {
            percentage = potion.rechargeValue * myStats.MAXhealthPoints;
            myStats.healthPoints = percentage + myStats.healthPoints;
        }
        else {
            percentage = potion.rechargeValue * myStats.MAXmanaPoints;
            myStats.manaPoints = percentage + myStats.manaPoints;
        }
    }

}
