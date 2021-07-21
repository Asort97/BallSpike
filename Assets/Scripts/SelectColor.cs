using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectColor : MonoBehaviour
{
    int chooseColor;
    private SpriteRenderer sp;
    void Start()
    {
        chooseColor = PlayerPrefs.GetInt("choosedColor");
        sp = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if (PlayerPrefs.GetInt("choosedColor") == 1)
        {
            sp.color = new Color(1, 0.7f, 0.3f, 1);
        }
        if(PlayerPrefs.GetInt("choosedColor") == 2)
        {
            sp.color = new Color(1, 0.2f, 0.15f, 1);
        }
        if(PlayerPrefs.GetInt("choosedColor") == 3)
        {
            sp.color = new Color(0.12f, 0.45f, 0.9f, 1);
        }
        if (PlayerPrefs.GetInt("choosedColor") == 4)
        {
            sp.color = new Color(0.9f, 0.4f, 0.43f, 1);
        }
        if (PlayerPrefs.GetInt("choosedColor") == 5)
        {
            sp.color = new Color(0.15f, 0.9f, 0.5f, 1);
        }
        if (PlayerPrefs.GetInt("choosedColor") == 6)
        {
            sp.color = new Color(0.18f, 0.9f, 0.12f, 1);
        }
        if (PlayerPrefs.GetInt("choosedColor") == 7)
        {
            sp.color = new Color(0.9f, 0.12f, 0.82f, 1);
        }
        if (PlayerPrefs.GetInt("choosedColor") == 8)
        {
            sp.color = new Color(0.15f, 0.93f, 0.88f, 1);
        }
        if (PlayerPrefs.GetInt("choosedColor") == 9)
        {
            sp.color = new Color(0.8f, 0.48f, 0.25f, 1);
        }
    }
}
