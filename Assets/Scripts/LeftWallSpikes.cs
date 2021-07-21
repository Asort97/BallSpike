using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftWallSpikes : MonoBehaviour
{
    public GameObject _spikePrefab;
    public ScoreController scoreContr;
    public BG bg;

    private void OnCollisionEnter2D(Collision2D col) {

        if(col.gameObject.tag == "Ball") {    

            scoreContr.PlusScore();
            bg.ChangeColor();
            StartCoroutine(wait());
            IEnumerator wait() {
                yield return new WaitForSeconds(0.5f);            
                Vector2 randomPos = new Vector2(Random.Range(-7.62f, -7.62f), Random.Range(-3.66f, 3.63f));
                GameObject _readySpike = Instantiate(_spikePrefab, randomPos, _spikePrefab.transform.rotation);
            }
        }
    }
}
