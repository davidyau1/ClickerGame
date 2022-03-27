using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //static and public allows the cookie variable to be used in other scripts via GameManager.cookies
    public static int dollars;
    public Text amountText;
    public GameObject upgrade1;
    public GameObject upgrade2;
    public GameObject upgrade3;
    public GameObject upgrade4;
    public Text upgradeText1;
    public Text upgradeText2;
    public Text upgradeText3;
    public Text upgradeText4;

    public static bool showUpgrade1;
    public static bool showUpgrade2;
    public static bool showUpgrade3;
    public static bool showUpgrade4;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        upgrade1.SetActive(showUpgrade1);
        upgrade2.SetActive(showUpgrade2);
        upgrade3.SetActive(showUpgrade3);
        upgrade4.SetActive(showUpgrade4);
           
        amountText.text = "$" + dollars;
    }
}
