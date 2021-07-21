using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG : MonoBehaviour
{
    int randnum;

    public void ChangeColor() 
    {
        randnum = Random.Range(0, 4);
        if(randnum == 0) {gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 1, 1, 1);}
        if(randnum == 1) {gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);}
        if(randnum == 2) {gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 1, 1);}
        if(randnum == 3) {gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1);}
        if(randnum == 4) {gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);}
    }
}
