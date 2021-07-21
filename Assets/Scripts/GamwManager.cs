using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamwManager : MonoBehaviour
{
    public Rigidbody2D rbBall;
    public GameObject Start_btn;
    public GameObject shopbtn;
    public GameObject RewardBtn;
    public GameObject SubBtn;
    public GameObject textBought;

    int CheckSubs;
    void Start()
    {
        CheckSubs = PlayerPrefs.GetInt("CheckingSubs");
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("CheckingSubs") == 1) {
            RewardBtn.SetActive(true);
            SubBtn.SetActive(false);
            textBought.SetActive(true);
        }
        if(PlayerPrefs.GetInt("CheckingSubs") == 0)  {
            RewardBtn.SetActive(false);
            SubBtn.SetActive(true);
            textBought.SetActive(false);
        }
    }
    public void StartBtn()
    {
        rbBall.constraints =   RigidbodyConstraints2D.None;
        rbBall.constraints =   RigidbodyConstraints2D.FreezeRotation;
        rbBall.AddForce(transform.right * -4f, ForceMode2D.Impulse);
        Start_btn.SetActive(false);
        shopbtn.SetActive(false);
    }

    public void Delete() {
        PlayerPrefs.DeleteAll();
    }
}
