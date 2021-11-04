using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> characterItems = new List<Item>();
    public ItemDatabase itemDatabase;
    public UIInventory uiInventory;

    private void Start()
    {
        AddItem(1);
        AddItem(0);
        AddItem(1);
        AddItem(0);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            uiInventory.gameObject.SetActive(!uiInventory.gameObject.activeInHierarchy);
        }
    }

    public void AddItem(int id)
    {
        Item itemToAdd = itemDatabase.GetItem(id);
        characterItems.Add(itemToAdd);
        uiInventory.AddNewItem(itemToAdd);
    }

    public void AddItem(string name)
    {
        Item itemToAdd = itemDatabase.GetItem(name);
        characterItems.Add(itemToAdd);
        uiInventory.AddNewItem(itemToAdd);
    }

    public Item CheckForItem(int id)
    {
        return characterItems.Find(item => item.id == id);
    }

    public void RemoveItem(int id)
    {
        Item itemToRemove = CheckForItem(id);
        if (itemToRemove != null)
        {
            characterItems.Remove(itemToRemove);
            uiInventory.RemoveItem(itemToRemove);
        }
    }
}
