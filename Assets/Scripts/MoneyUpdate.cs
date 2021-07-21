using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyUpdate : MonoBehaviour
{
    public Text CashText;
    int cash;
    void Start()
    {
        cash = PlayerPrefs.GetInt("Money");
        CashText.text = "" + cash;
    }

    
    void Update()
    {
        cash = PlayerPrefs.GetInt("Money");
        CashText.text = "" + cash;
    }
}
