using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
using System;
public class EveryDayBablo : MonoBehaviour
{
    [SerializeField]private float msToWait = 50000.0f;
    public Text Timer;
    private Button RewardButton;
    private ulong lastOpen;
    private int cash;
    private int CheckSubs;

    private void Start()
    {
        RewardButton = GetComponent<Button>();
        lastOpen = ulong.Parse(PlayerPrefs.GetString("lastOpen"));
        CheckSubs = PlayerPrefs.GetInt("CheckingSubs");
        if(CheckSubs == 1) {
            if(!isReady()) {
            RewardButton.interactable = false;
            }
        }
  
    }

    // Update is called once per frame
    void Update()
    {

        if(CheckSubs == 1) {
            if(!RewardButton.IsInteractable()) {
                if(isReady()) {
                    RewardButton.interactable = true;
                    Timer.text = "готво!";
                    return;
                }
                ulong diff = ((ulong)DateTime.Now.Ticks - lastOpen);
                ulong m = diff / TimeSpan.TicksPerMillisecond;
                float seconleft = (float)(msToWait - m) / 1000.0f;

                string t = "";

                t += ((int)seconleft / 3600).ToString() + "ч ";
                seconleft -= ((int)seconleft / 3600) * 3600;
                t += ((int)seconleft / 60).ToString("00") + "м ";
                t += ((int)seconleft % 60).ToString("00") + "с ";

                Timer.text = t;
            }
        }

    }

    public void Click() {
        cash = PlayerPrefs.GetInt("Money");
        cash += 1000;
        PlayerPrefs.SetInt("Money", cash);

        lastOpen = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("lastOpen", lastOpen.ToString());
        RewardButton.interactable = false;

        
    }

    private bool isReady() {
        ulong diff = ((ulong)DateTime.Now.Ticks - lastOpen);
        ulong m = diff / TimeSpan.TicksPerMillisecond;
        float seconleft = (float)(msToWait - m) / 1000.0f;

        if(seconleft < 0) {
            Timer.text = "Ready!";
            return true;
        }
        return false;
    }
}
