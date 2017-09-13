using UnityEngine;
using System.Collections;

[System.Serializable]
public class Skills{
    public enum type {
        attack,
        buff
    }

    public type skillType;
    public string skillName;
    public float damage;
    public string description;

    public Skills() {

    }

    public Skills(string skillName, float damage, string desc, type skillType) {
        this.skillName = skillName;
        this.damage = damage;
        this.skillType = skillType;
        this.description = desc;
    }


}
