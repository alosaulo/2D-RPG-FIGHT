using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Persona : MonoBehaviour
{

    public Races myRace;
    public Classes myClass;
    public Attributes myAttributes;
    public Stats myStats;

    public string GetJobAndRaceNames()
    {
        return (myRace.RaceName + myClass.ClassName);
    }

    [Header("Character Name")] public string charaName;
    
    [Header("Experience")]public int lvlpoints;
    
    [Header("Total Atk")]protected float ATK;
    [Header("Total Def")]protected float DEF;
}
