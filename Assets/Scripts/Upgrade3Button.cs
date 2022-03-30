using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Upgrade3Button : MonoBehaviour
{
    int upgradeCost=800;
    int increaseDPS = 50;

    public Text upgradeButtonText;
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
            PassiveUpgrades.upgrade3Dps += increaseDPS;
            //increases cost for next upgrade
            upgradeCost += 20;
            //updates button text
            UpdateText();
            //display upgrade
            PassiveUpgrades.showUpgrade3 = true;
            //count time upgraded
            PassiveUpgrades.timesUpgraded3++;
        }
        else
        {

        }
    }
    //function to update button text
    private void UpdateText()
    {
        //display the increase in click and price to purchase upgrade
        upgradeButtonText.text =  "Hire Wizard for $" + upgradeCost + "\n" + "Increase $" + increaseDPS+"/sec" ;

    }
}
