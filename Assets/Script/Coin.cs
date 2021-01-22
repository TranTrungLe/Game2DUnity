using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            Score.coinAmount += 1;
            Destroy(gameObject);
            if (Score.coinAmount > HighScore.highscore)
            {
                HighScore.highscore = Score.coinAmount;
            }
        }       
    }
}
