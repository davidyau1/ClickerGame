using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //static and public allows the cookie variable to be used in other scripts via GameManager.cookies
    public static int dollars;
    public Text amountText;
     // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      
        amountText.text = "$" + dollars;
    }
}
