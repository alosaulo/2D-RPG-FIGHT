using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransactionManager : MonoBehaviour {

    ShoppingManager shoppingManager;
    PlayerPersona player;

    private void Awake()
    {
        shoppingManager = GetComponent<ShoppingManager>();
        player = shoppingManager.player;
    }

    public void BuyItem() {
        if (isItemSelected()) { 
            if (player.myGold >= shoppingManager.selectedItem.itemValue)
            {
                shoppingManager.textItemDescription.text = "Compra efetuada com sucesso!";
                player.myInventory.AddItem(shoppingManager.selectedItem);
            }
            else {
                shoppingManager.textItemDescription.text = "Você não possui dinheiro suficiente!";
            }
        }
        shoppingManager.selectedItem = null;
    }

    public void SellItem() {
        if (shoppingManager.playerSelectedItem != null)
        {
            player.myGold += shoppingManager.selectedItem.itemValue;
            shoppingManager.textItemDescription.text = "Venda feita com sucesso.";
        }
        else {
            shoppingManager.textItemDescription.text = "Selecione um item para vender.";
        }
        shoppingManager.playerSelectedItem = null;
    }

    public bool isItemSelected() {
        if (shoppingManager.selectedItem == null)
        {
            return false;
        }
        else {
            return true;
        }
    }

    public void GoFight() {

    }
}
