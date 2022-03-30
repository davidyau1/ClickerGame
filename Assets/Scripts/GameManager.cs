using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //static and public allows the cookie variable to be used in other scripts via GameManager.cookies
    public static int dollars;
    public Text amountText;
    public Text dps;

     // Start is called before the first frame update
    void Start()
    {
        //calls add DPS to total every on second
        InvokeRepeating("addDPSToTotal", 0f, 1f);
    }
    //added dollars per second total
    public void addDPSToTotal()
    {
        dollars += PassiveUpgrades.totalDps; 
    }
    // Update is called once per frame
    void Update()
    {
        //updates dps text
        dps.text = "$" + PassiveUpgrades.totalDps +"/sec";
        //updates click button text

        amountText.text = "$" + dollars;
    }
}
