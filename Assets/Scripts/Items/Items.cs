using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Items : MonoBehaviour {
    [HideInInspector]
    public GameObject itemPrefab;
    [HideInInspector]
    public Sprite itemSprite;

    public string itemDescription;
    public double itemValue;

    protected virtual void Awake() {
        itemPrefab = gameObject;
        itemSprite = gameObject.transform.FindChild("Image").GetComponent<Image>().sprite;
    }

}
