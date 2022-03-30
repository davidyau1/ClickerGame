using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PassiveUpgrades : MonoBehaviour
{
    //dollars per second per upgrade type
    public static int upgrade1Dps;
    public static int upgrade2Dps;
    public static int upgrade3Dps;
    public static int upgrade4Dps;
    //total dollars per second
    public static int totalDps;
    //ui gameobject displaying upgrades
    public GameObject upgrade1;
    public GameObject upgrade2;
    public GameObject upgrade3;
    public GameObject upgrade4;
    //upgrade text
    public Text upgradeText1;
    public Text upgradeText2;
    public Text upgradeText3;
    public Text upgradeText4;
    //show or hide gameobject
    public static bool showUpgrade1;
    public static bool showUpgrade2;
    public static bool showUpgrade3;
    public static bool showUpgrade4;
    //count number of time upgrade occurs
    public static int timesUpgraded1;
    public static int timesUpgraded2;
    public static int timesUpgraded3;
    public static int timesUpgraded4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //total dollars per second
        totalDps = upgrade1Dps+upgrade2Dps+upgrade3Dps+upgrade4Dps;
        //show or hide upgrade dollars per second for upgrade 1-4
        upgrade1.SetActive(showUpgrade1);
        upgrade2.SetActive(showUpgrade2);
        upgrade3.SetActive(showUpgrade3);
        upgrade4.SetActive(showUpgrade4);
        //show text for upgrade 1-4
        upgradeText1.text = "Peasants (" + timesUpgraded1+")"+ "\n" + "$" + upgrade1Dps + "/sec";
        upgradeText2.text = "Knights (" + timesUpgraded2 +")"+"\n" + "$" + upgrade2Dps + "/sec";
        upgradeText3.text = "Wizards (" + timesUpgraded3 +")"+"\n" + "$" + upgrade3Dps + "/sec";
        upgradeText4.text = "Dragons (" + timesUpgraded4 +")"+"\n" + "$" + upgrade4Dps + "/sec";


    }
  
}
