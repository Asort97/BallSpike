using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public GameObject ShopImg;
    public GameObject Start_btn;
    public void OpenShop()
    {
        ShopImg.SetActive(true);
        Start_btn.SetActive(false);
        Time.timeScale = 0f;
    }
    public void CloseShop()
    {
        ShopImg.SetActive(false);
        Start_btn.SetActive(true);
        Time.timeScale = 1f;
    }
}
