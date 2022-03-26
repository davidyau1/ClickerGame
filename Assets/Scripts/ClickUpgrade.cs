using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickUpgrade : MonoBehaviour
{

    int upgradeClickCost = 20;
    int increaseClick = 1;
    public Text upgradeClickCostText;
    private void Start()
    {
        UpdateText();
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
            Debug.Log("not enough cookies");
        }
    }
    //function to update button text
    private void UpdateText()
    {
        upgradeClickCostText.text = "Increase Click by $"+increaseClick+ "\n" +"Cost $" + upgradeClickCost;

    }
}
