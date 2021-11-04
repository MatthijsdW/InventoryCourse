using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    private void Awake()
    {
        BuildDatabase();
    }

    public Item GetItem(int id)
    {
        return items.Find(x => x.id == id);
    }

    public Item GetItem(string itemName)
    {
        return items.Find(x => x.title == itemName);
    }

    private void BuildDatabase()
    {
        items = new List<Item>()
        {
            new Item(0, "Diamond Sword", "A sword made of diamond.",
            new Dictionary<string, int>()
            {
                { "Power", 15 },
                { "Defence", 10 }
            }),
            new Item(1, "Diamond Ore", "An ore made of diamond.",
            new Dictionary<string, int>()
            {
                { "Value", 300 }
            }),
            new Item(2, "Silver Pick", "A pick made of silver.",
            new Dictionary<string, int>()
            {
                { "Power", 5 },
                { "Mining", 20 }
            }),
            new Item(3, "Emerald Ore", "An ore made of emerald.",
            new Dictionary<string, int>()
            {
                { "Value", 200 }
            }),
            new Item(4, "Diamond Pick", "A pick made of diamond.",
            new Dictionary<string, int>()
            {
                { "Power", 10 },
                { "Mining", 30 }
            }),
            new Item(5, "Gold Ore", "An ore made of gold.",
            new Dictionary<string, int>()
            {
                { "Value", 100 }
            }),
        };
    }
}
