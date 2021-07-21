using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subscribe : MonoBehaviour
{
    public GameObject SubPanel;
    public void OnButtonDown()
    {
        SubPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void UpButtomDown()
    {
        SubPanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void BuySubscribe()
    {
        Debug.Log("подписка оформлена");
    }
}
