using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PassiveUpgrades : MonoBehaviour
{
    public static int upgrade1Dps;
    public static int upgrade2Dps;
    public static int upgrade3Dps;
    public static int upgrade4Dps;
    public GameObject upgrade1;
    public GameObject upgrade2;
    public GameObject upgrade3;
    public GameObject upgrade4;
    public Text upgradeText1;
    public Text upgradeText2;
    public Text upgradeText3;
    public Text upgradeText4;
    public bool showUpgrade1;
    public bool showUpgrade2;
    public bool showUpgrade3;
    public bool showUpgrade4;
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
        upgradeText1.text = "Upgrade 1" + "\n" + "$" + upgrade1Dps + "/sec";
        upgradeText2.text = "Upgrade 2" + "\n" + "$" + upgrade2Dps + "/sec";
        upgradeText3.text = "Upgrade 3" + "\n" + "$" + upgrade3Dps + "/sec";
        upgradeText4.text = "Upgrade 4" + "\n" + "$" + upgrade4Dps + "/sec";


    }
    void Upgrade1()
    {

    }
    void Upgrade2()
    {

    }
    void Upgrade3()
    {

    }
    void Upgrade4()
    {

    }
}
