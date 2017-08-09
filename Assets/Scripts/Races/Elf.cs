using UnityEngine;
using System.Collections;

public class Elf : Races {
    public Elf() {
        RaceDescription = "Ganha modificador de +1 em inteligência e destreza e -2 em força";
        modFOR = -2;
        modDEX = 1;
        modINT = 1;
    }
}
