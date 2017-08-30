using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Mage : Classes {

    

    public Mage() {
        SetSkills();
        ClassName = "Mage";
        ClassDescription = "Ganha bonus de 75% da sua mana total, recupera mana por turno. Seu ataque é baseado em sua inteligência.";
    }

    protected override void SetSkills()
    {
        string skill1Desc = "A magia mais poderosa de um mago, seu dano é representado pela formula (dano=manaAtual*1.5)";
        string skill2Desc = "Magia protetora que cobre o mago com um manto de mana, fazendo com que a a mana receba o ataque. " +
            "O escudo, assim que ativado, dura 5 turnos." +
            "Caso haja excesso do ataque, desconta da vida. (perdaDeMana = ataque * 0.8) ";
        Skills skill1 = new Skills("Bola de Fogo", 0, skill1Desc, Skills.type.attack);
        Skills skill2 = new Skills("Escudo de Mana", 0, skill2Desc, Skills.type.buff);
        skills.Add(skill1);
        skills.Add(skill2);
    }
}
