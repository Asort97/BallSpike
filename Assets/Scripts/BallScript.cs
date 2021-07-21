using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    private Rigidbody2D rb;

    public GameObject DiePanel;
    public GameObject burstPrefab;
    public GameObject burst2Prefab;
    public GameObject burst3Prefab;

    public Text text_currentScore;
    public Text text_bestScore;
    public Text text_nameBest;
    int cash;
    void Start()
    {
        cash = PlayerPrefs.GetInt("Money");
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * -4f, ForceMode2D.Impulse);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * 6f, ForceMode2D.Impulse);
            Instantiate(burst2Prefab, gameObject.transform);
        }
    }

    void OnCollisionEnter2D(Collision2D col) 
    {
        if(col.gameObject.tag == "Ground") 
        {
            // Instantiate(burstPrefab, gameObject.transform);
            rb.AddForce(transform.up * 9f, ForceMode2D.Impulse);
            
        }
        if(col.gameObject.tag == "leftWall") 
        {
            // Instantiate(burstPrefab, gameObject.transform);
            rb.AddForce(transform.right * 5f, ForceMode2D.Impulse);
            
        }
        if(col.gameObject.tag == "rightWall") 
        {
            // Instantiate(burstPrefab, gameObject.transform);
            rb.AddForce(transform.right * -5f, ForceMode2D.Impulse);
            
        }

        if(col.gameObject.tag == "Spike")
        {
            text_bestScore.color = Color.white;
            text_currentScore.color = Color.white;
            text_nameBest.color = Color.white;
            
            Instantiate(burst3Prefab, gameObject.transform);
            
            Time.timeScale = 0f;
            DiePanel.SetActive(true);
        }
    }
    // void OnCollisionStay2D(Collision2D col) {
                
    //     if(col.gameObject.tag == "Ground") 
    //     {
    //         Instantiate(burstPrefab, gameObject.transform);
    //     }
    //     if(col.gameObject.tag == "leftWall") 
    //     {
    //         Instantiate(burstPrefab, gameObject.transform);
    //     }
    //     if(col.gameObject.tag == "rightWall") 
    //     {
    //         Instantiate(burstPrefab, gameObject.transform);     
    //     }

    // }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Coin")
        {
            cash = PlayerPrefs.GetInt("Money");
            cash += 15;
            PlayerPrefs.SetInt("Money", cash);
            Destroy(other.gameObject);
        }
        if(other.tag == "particles") {
            Instantiate(burstPrefab, gameObject.transform);     
        }
    }
}
