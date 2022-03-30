using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickUpgrade : MonoBehaviour
{
    // cost to upgrade
    int upgradeClickCost = 20;
    // benefit to upgrade
    int increaseClick = 2;
    //button text
    public Text upgradeClickCostText;
    //upgrade cost
    public Button upgradeClickCostButton;
    private void Start()
    {
        //update button text
        UpdateText();
    }
    public void Update()
    {
        //if not enough money buttons is not interactable
        if (GameManager.dollars<upgradeClickCost)
        {
            upgradeClickCostButton.interactable = false;
        }
        //otherwise allow interactive button
        else
        {
            upgradeClickCostButton.interactable=true;
        }
    }
    public void Clicked()
    {
        //checks if enought cookies to buy
        if (GameManager.dollars >= upgradeClickCost)
        {
            //reduces total cookies by cost
            GameManager.dollars  -=upgradeClickCost;
            //increases cookie per click
            IncreaseButton.clickValue += increaseClick;
            //increases cost for next upgrade
            upgradeClickCost += 20;
            //updates button text
            UpdateText();
        }
        else
        {

        }
    }
    //function to update button text
    private void UpdateText()
    {
        //display the increase in click and price to purchase upgrade
        upgradeClickCostText.text = "Improve Click for $"+upgradeClickCost+"\n"+"Increase Click by $"+increaseClick;

    }
}
