using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CUpgrade : MonoBehaviour
{
    
    public Text upgradeDisplayer;

    public string upgradeName;

    [HideInInspector]
    public int goldByUpgrade;
    public int startGoldByUpgrade = 1;

    [HideInInspector]
    public int currentCost = 1;
    public int startCurrentCost = 1;

    public int level = 1;

    public float upgradePow = 1.07f;
    public float costPow = 3.14f;

    void Start()
    {
        currentCost = startCurrentCost;
        level = 1;
        goldByUpgrade = startGoldByUpgrade;
        UpdateUI();
    }

    public void PurchaseUpgrade()
    {
        if(CDataController.GetInstance().GetGold() >= currentCost)
        {
            CDataController.GetInstance().SubGold(currentCost);
            level++;
            CDataController.GetInstance().AddGoldPerClick(goldByUpgrade);

            UpdateUpgrade();
            UpdateUI();
        }
    }

    public void UpdateUpgrade()
    {
        goldByUpgrade = startGoldByUpgrade * (int)Mathf.Pow(upgradePow, level);
        currentCost = startCurrentCost * (int)Mathf.Pow(costPow, level);
    }

    public void UpdateUI()
    {
        upgradeDisplayer.text = upgradeName + "\nCost : " + currentCost + "\nLevel : " + level + "\nNext New GoldPerClick : " + goldByUpgrade;
    }

}
