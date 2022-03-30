using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseButton : MonoBehaviour
{
    //click value
    public static int clickValue = 1;
    //text for click value
    public Text clickValueText;


    public void Clicked()
    {
        //increases dollar by click value when clicked
        GameManager.dollars += clickValue;
    }
    public void Update()
    {
        //displays click value
        clickValueText.text = "+ $" + clickValue;
    }



}
