using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inventory : MonoBehaviour{
    public const int numItemSlot = 4;

    public GameObject IventarioPlayer;

    public Items[] items = new Items[numItemSlot];
    public GameObject[] slots = new GameObject[numItemSlot];

    public void AddItem(Items item) {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = item;
                slots[i].transform.Find("Image").GetComponent<Image>().sprite = item.itemSprite;
                return;
            }
        }
    }

    public void RemoveItem(Items item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == item)
            {
                items[i] = null;
                slots[i].transform.Find("Image").GetComponent<Image>().sprite = null;
                return;
            }
        }
    }

    public void InventoryActivated(Scene scene, LoadSceneMode mode) {
        switch (scene.name) {
            case "CreationScene":
                IventarioPlayer.SetActive(false);
                break;
            case "InnScene":
                IventarioPlayer.SetActive(true);
                slots[0].GetComponent<Button>();
                break;
            case "FightScene":
                IventarioPlayer.SetActive(true);
                break;
            case "LvlUpScene":
                IventarioPlayer.SetActive(false);
                break;
        }
        Debug.Log(scene.name);
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += InventoryActivated;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= InventoryActivated;
    }
}
