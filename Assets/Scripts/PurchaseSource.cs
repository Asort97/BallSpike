using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;
public class PurchaseSource : MonoBehaviour
{
    public Text CashText;
    private int cash;
    public GameObject RewardBtn;
    int CheckSubs;

    void Start()
    {
        cash = PlayerPrefs.GetInt("Money");
        CheckSubs = PlayerPrefs.GetInt("CheckingSubs");
    }

    public void OnPurchaseComplete(Product product) {

        if(product.definition.id == "everry100");
        if( CheckSubs == 0) {
            Debug.Log("Плюс мани");
            cash = PlayerPrefs.GetInt("Money");
            cash += 1000;
            CashText.text = ""  + cash;
            CheckSubs = 1;
            PlayerPrefs.SetInt("CheckingSubs", CheckSubs);
            PlayerPrefs.SetInt("Money", cash);
        }

    } 

    public void OnPurchaseFailure(Product product, PurchaseFailureReason reason ) {
        Debug.Log("Бабла нету");
    }

}
