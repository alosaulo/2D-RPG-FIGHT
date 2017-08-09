using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingManager : MonoBehaviour {

    public Text textItemDescription;
    public Text amountExp;
    public Text amountGold;
    public GameObject IventoryContent;

    public List<Items> Estoque;

    static ShoppingManager _instance;

    [HideInInspector]
    public PlayerPersona player;

    [HideInInspector]
    public Items selectedItem;
    public Items playerSelectedItem;

    void Awake () {
        _instance = this;
        FillStock();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerPersona>();
        player.myStats.healthPoints = player.myStats.MAXhealthPoints;
    }

    void FillStock() {

    }

    public void DisplayItemDescription(int value) {
        selectedItem = Estoque[value];
        textItemDescription.text = selectedItem.itemDescription;
    }

}
