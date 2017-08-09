using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potions : Items {

    public enum PotionType{
        Health,
        Mana
    }

    public float rechargeValue;
    public PotionType potionType;
}
