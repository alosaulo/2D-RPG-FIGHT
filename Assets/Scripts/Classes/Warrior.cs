using UnityEngine;
using System.Collections;

public class Warrior : Classes {   

    public Warrior() {
        SetSkills();
        ClassName = "Warrior";
        ClassDescription = "Ganhe bonus de 25% em sua vida total. Seu ataque é baseado em sua força.";
    }

    protected override void SetSkills() {
        string skill1Desc = "Dá dano em relação a (vida atual * 1.3) no inimigo.";
        string skill2Desc = "Aumenta a resistência de ataques por 5 turnos.";
        Skills skill1 = new Skills("Investida", 0, skill1Desc, Skills.type.attack);
        Skills skill2 = new Skills("Tenacidade", 0,skill2Desc, Skills.type.buff);
        skills.Add(skill1);
        skills.Add(skill2);
    }
}
