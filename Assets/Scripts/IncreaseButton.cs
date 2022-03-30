using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseButton : MonoBehaviour
{

    public static int clickValue = 100;
    public Text clickValueText;


    public void Clicked()
    {
        GameManager.dollars += clickValue;
    }
    public void Update()
    {
        clickValueText.text = "+ $" + clickValue;
    }



}
