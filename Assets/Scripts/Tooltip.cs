using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tooltip : MonoBehaviour
{
    TextMeshProUGUI tooltipText;

    void Start()
    {
        tooltipText = GetComponentInChildren<TextMeshProUGUI>();
        gameObject.SetActive(false);
    }


    public void GenerateTooltip(Item item)
    {
        string statText = "";
        foreach (var stat in item.stats)
        {
            statText += $"\n{stat.Key}: {stat.Value}";
        }

        tooltipText.text = $"<b>{item.title}</b>\n{item.description}\n<b>{statText}</b>";
        gameObject.SetActive(true);
    }


}
