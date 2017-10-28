using UnityEngine;
using System.Collections;

public class Orc : Races {
    public Orc()
    {
        RaceName = "Orc";
        RaceDescription = "Ganha modificador de +2 em força e -2 em inteligência";
        modFOR = 2;
        modDEX = 0;
        modINT = -2;
    }
}
