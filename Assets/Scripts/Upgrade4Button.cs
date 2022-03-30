using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Upgrade4Button : MonoBehaviour
{
    //upgrade cost
    int upgradeCost = 5000;
    //increases in dollars per second
    int increaseDPS = 200;
    //button text
    public Text upgradeButtonText;
    //button
    public Button upgradeButton;
    private void Start()
    {
        //update button text
        UpdateText();
    }
    public void Update()
    {

        //if not enough money buttons is not interactable
        if (GameManager.dollars < upgradeCost)
        {
            upgradeButton.interactable = false;
        }
        //otherwise allow interactive button
        else
        {
            upgradeButton.interactable = true;
        }
    }
    public void Clicked()
    {
        //checks if enought cookies to buy
        if (GameManager.dollars >= upgradeCost)
        {
            //reduces total cookies by cost
            GameManager.dollars -= upgradeCost;
            //increases cookie per click
            PassiveUpgrades.upgrade4Dps += increaseDPS;
            //increases cost for next upgrade
            upgradeCost += 2000;
            //updates button text
            UpdateText();
            //display upgrade
            PassiveUpgrades.showUpgrade4 = true;
            //count times upgraded
            PassiveUpgrades.timesUpgraded4++;
        }
        else
        {

        }
    }
    //function to update button text
    private void UpdateText()
    {
        //display the increase in benefit and price to purchase upgrade
        upgradeButtonText.text = "Hire Dragon for $" + upgradeCost + "\n" + "Increase $" + increaseDPS + "/sec";

    }
}
