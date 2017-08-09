using UnityEngine;
using System.Collections;

public class Dwarf : Races {
    public Dwarf() {
        RaceDescription = "Ganha modificador de +2 em força e -2 em inteligência";
        modFOR = 2;
        modDEX = 0;
        modINT = -2;
    }
}
