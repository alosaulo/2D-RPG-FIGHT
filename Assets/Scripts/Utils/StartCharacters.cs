using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[System.Serializable]
public class StartCharacters {

    public Sprite mySprite;
    public string myName;

    public StartCharacters(string myName, Sprite mySprite) {
        this.mySprite = mySprite;
        this.myName = myName;
    }

}
