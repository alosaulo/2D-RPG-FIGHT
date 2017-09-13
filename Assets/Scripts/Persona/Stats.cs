using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Stats
{
    public float MAX_healthPoints;
    public float healthPoints;
    public float MAX_manaPoints;
    public float manaPoints;

    public void SetMaxLifePoints(int lifePoints)
    {
        MAX_healthPoints = lifePoints;
    }

    public void SetMaxManaPoints(int manaPoints)
    {
        MAX_manaPoints = manaPoints;
    }

    public void SetActualLifePoints(int lifePoints)
    {
        this.healthPoints = lifePoints;
    }

    public void SetActualManaPoints(int manaPoints)
    {
        this.manaPoints = manaPoints;
    }

}
