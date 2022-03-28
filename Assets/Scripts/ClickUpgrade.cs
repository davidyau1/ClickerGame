using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickUpgrade : MonoBehaviour
{

    int upgradeClickCost = 20;
    int increaseClick = 1;
    public Text upgradeClickCostText;
    public Button upgradeClickCostButton;
    private void Start()
    {
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
        upgradeClickCostText.text = "Increase Click by $"+increaseClick+ "\n" +"Cost $" + upgradeClickCost;

    }
}
