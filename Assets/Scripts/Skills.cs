using UnityEngine;
using System.Collections;

public class Skills{
    public enum type {
        attack,
        buff
    }
    public type skillType { get; set; }
    public string skillName { get; set; }
    public float damage { get; set;}
    public string description { get; set; }

    public Skills() {

    }

    public Skills(string skillName, float damage, string desc, type skillType) {
        this.skillName = skillName;
        this.damage = damage;
        this.skillType = skillType;
        this.description = desc;
    }


}
