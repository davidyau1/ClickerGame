using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Upgrade2Button : MonoBehaviour
{
    int upgradeCost=250;
    int increaseDPS = 10;
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
            PassiveUpgrades.upgrade2Dps += increaseDPS;
            //increases cost for next upgrade
            upgradeCost += 20;
            //updates button text
            UpdateText();
            PassiveUpgrades.showUpgrade2 = true;
        }
        else
        {

        }
    }
    //function to update button text
    private void UpdateText()
    {
        //display the increase in click and price to purchase upgrade
        upgradeButtonText.text = "Increase $" + increaseDPS+"/sec" + "\n" + "Cost $" + upgradeCost;

    }
}
