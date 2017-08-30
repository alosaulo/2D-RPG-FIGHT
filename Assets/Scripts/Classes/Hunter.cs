using UnityEngine;
using System.Collections;

public class Hunter : Classes {

    public Hunter() {
        SetSkills();
        ClassName = "Hunter";
        ClassDescription = "Possui uma chance maior de esquivar do ataque do inimigo (25% de sua destreza) e seu ataque é baseado em sua destreza.";
    }

    protected override void SetSkills()
    {
        string skill1Desc = " Ataca um ponto vital do inimigo. dano = destreza*1.2";
        string skill2Desc = "Aumenta a chance de acertar do caçador. Cada ataque por 5 turnos, possui 25% do dano.";
        Skills skill1 = new Skills("Tiro Certeiro", 0, skill2Desc, Skills.type.attack);
        Skills skill2 = new Skills("Precisão", 0, skill1Desc, Skills.type.buff);
        skills.Add(skill1);
        skills.Add(skill2);
    }
}
