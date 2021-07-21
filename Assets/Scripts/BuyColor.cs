using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyColor : MonoBehaviour
{
    int cash;
    int HaveColor1;
    int HaveColor2;
    int HaveColor3;
    int HaveColor4;
    int HaveColor5;
    int HaveColor6;
    int HaveColor7;
    int HaveColor8;
    int HaveColor9;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;
    public GameObject text9;
    public GameObject price1;
    public GameObject price2;
    public GameObject price3;
    public GameObject price4;
    public GameObject price5;
    public GameObject price6;
    public GameObject price7;
    public GameObject price8;
    public GameObject price9;
    int chooseColor;
    void Start()
    {
        cash = PlayerPrefs.GetInt("Money");
        
        HaveColor1 = PlayerPrefs.GetInt("HavedColor1");
        HaveColor2 = PlayerPrefs.GetInt("HavedColor2");
        HaveColor3 = PlayerPrefs.GetInt("HavedColor3");
        HaveColor4 = PlayerPrefs.GetInt("HavedColor4");
        HaveColor5 = PlayerPrefs.GetInt("HavedColor5");
        HaveColor6 = PlayerPrefs.GetInt("HavedColor6");
        HaveColor7 = PlayerPrefs.GetInt("HavedColor7");
        HaveColor8 = PlayerPrefs.GetInt("HavedColor8");
        HaveColor9 = PlayerPrefs.GetInt("HavedColor9");

        chooseColor = PlayerPrefs.GetInt("choosedColor");

        if (HaveColor1 == 1)
        {
            text1.SetActive(true);
            price1.SetActive(false);
        }

        if (HaveColor2 == 1)
        {
            text2.SetActive(true);
            price2.SetActive(false);
        }


        if (HaveColor3 == 1)
        {
            text3.SetActive(true);
            price3.SetActive(false);
        }


        if (HaveColor4 == 1)
        {
            text4.SetActive(true);
            price4.SetActive(false);
        }


        if (HaveColor5 == 1)
        {
            text5.SetActive(true);
            price5.SetActive(false);
        }


        if (HaveColor6 == 1)
        {
            text6.SetActive(true);
            price6.SetActive(false);
        }


        if (HaveColor7 == 1)
        {
            text7.SetActive(true);
            price7.SetActive(false);
        }


        if (HaveColor8 == 1)
        {
            text8.SetActive(true);
            price8.SetActive(false);
        }


        if (HaveColor9 == 1)
        {
            text9.SetActive(true);
            price9.SetActive(false);
        }
    }

    void Update()
    {
        if (HaveColor1 == 1)
        {
            text1.SetActive(true);
            price1.SetActive(false);
        }

        if (HaveColor2 == 1)
        {
            text2.SetActive(true);
            price2.SetActive(false);
        }


        if (HaveColor3 == 1)
        {
            text3.SetActive(true);
            price3.SetActive(false);
        }


        if (HaveColor4 == 1)
        {
            text4.SetActive(true);
            price4.SetActive(false);
        }


        if (HaveColor5 == 1)
        {
            text5.SetActive(true);
            price5.SetActive(false);
        }


        if (HaveColor6 == 1)
        {
            text6.SetActive(true);
            price6.SetActive(false);
        }


        if (HaveColor7 == 1)
        {
            text7.SetActive(true);
            price7.SetActive(false);
        }


        if (HaveColor8 == 1)
        {
            text8.SetActive(true);
            price8.SetActive(false);
        }


        if (HaveColor9 == 1)
        {
            text9.SetActive(true);
            price9.SetActive(false);
        }
    }
    public void OnBuyColor1()
    {
        if (HaveColor1 == 0 && cash >= 200)
        {
            HaveColor1 = 1;
            PlayerPrefs.SetInt("HavedColor1", HaveColor1);
            cash -= 200;
            PlayerPrefs.SetInt("Money", cash);
            text1.SetActive(true);
        }
        else if (HaveColor1 == 1)
        {
            chooseColor = 1;
            PlayerPrefs.SetInt("choosedColor", chooseColor);
            text1.SetActive(true);
        }
    }
    public void OnBuyColor2()
    {
        if (HaveColor2 == 0 && cash >= 200)
        {
            HaveColor2 = 1;
            PlayerPrefs.SetInt("HavedColor2", HaveColor2);
            cash -= 200;
            PlayerPrefs.SetInt("Money", cash);
            text2.SetActive(true);
        }
        else if (HaveColor2 == 1)
        {
            chooseColor = 2;
            PlayerPrefs.SetInt("choosedColor", chooseColor);
            text2.SetActive(true);
        }
    }
    public void OnBuyColor3()
    {
        if (HaveColor3 == 0 && cash >= 200)
        {
            HaveColor3 = 1;
            PlayerPrefs.SetInt("HavedColor3", HaveColor3);
            cash -= 200;
            PlayerPrefs.SetInt("Money", cash);
            text3.SetActive(true);
        }
        else if (HaveColor3 == 1)
        {
            chooseColor = 3;
            PlayerPrefs.SetInt("choosedColor", chooseColor);
            text3.SetActive(true);
        }
    }
    public void OnBuyColor4()
    {
        if (HaveColor4 == 0 && cash >= 200)
        {
            HaveColor4 = 1;
            PlayerPrefs.SetInt("HavedColor4", HaveColor4);
            cash -= 200;
            PlayerPrefs.SetInt("Money", cash);
            text4.SetActive(true);
        }
        else if (HaveColor4 == 1)
        {
            chooseColor = 4;
            PlayerPrefs.SetInt("choosedColor", chooseColor);
            text4.SetActive(true);
        }
    }
    public void OnBuyColor5()
    {
        if (HaveColor5 == 0 && cash >= 200)
        {
            HaveColor5 = 1;
            PlayerPrefs.SetInt("HavedColor5", HaveColor5);
            cash -= 200;
            PlayerPrefs.SetInt("Money", cash);
            text5.SetActive(true);
        }
        else if (HaveColor5 == 1)
        {
            chooseColor = 5;
            PlayerPrefs.SetInt("choosedColor", chooseColor);
            text5.SetActive(true);
        }
    }
    public void OnBuyColor6()
    {
        if (HaveColor6 == 0 && cash >= 200)
        {
            HaveColor6 = 1;
            PlayerPrefs.SetInt("HavedColor6", HaveColor6);
            cash -= 200;
            PlayerPrefs.SetInt("Money", cash);
            text6.SetActive(true);
        }
        else if (HaveColor6 == 1)
        {
            chooseColor = 6;
            PlayerPrefs.SetInt("choosedColor", chooseColor);
            text6.SetActive(true);
        }
    }
    public void OnBuyColor7()
    {
        if (HaveColor7 == 0 && cash >= 200)
        {
            HaveColor7 = 1;
            PlayerPrefs.SetInt("HavedColor7", HaveColor7);
            cash -= 200;
            PlayerPrefs.SetInt("Money", cash);
            text7.SetActive(true);
        }
        else if (HaveColor7 == 1)
        {
            chooseColor = 7;
            PlayerPrefs.SetInt("choosedColor", chooseColor);
            text7.SetActive(true);
        }
    }
    public void OnBuyColor8()
    {
        if (HaveColor8 == 0 && cash >= 200)
        {
            HaveColor8 = 1;
            PlayerPrefs.SetInt("HavedColor8", HaveColor8);
            cash -= 200;
            PlayerPrefs.SetInt("Money", cash);
            text8.SetActive(true);
        }
        else if (HaveColor8 == 1)
        {
            chooseColor = 8;
            PlayerPrefs.SetInt("choosedColor", chooseColor);
            text8.SetActive(true);
        }
    }
    public void OnBuyColor9()
    {
        if (HaveColor9 == 0 && cash >= 200)
        {
            HaveColor9 = 1;
            PlayerPrefs.SetInt("HavedColor9", HaveColor9);
            cash -= 200;
            PlayerPrefs.SetInt("Money", cash);
            text9.SetActive(true);
        }
        else if (HaveColor9 == 1)
        {
            chooseColor = 9;
            PlayerPrefs.SetInt("choosedColor", chooseColor);
            text9.SetActive(true);
        }
    }
}
