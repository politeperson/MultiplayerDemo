using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text myScoreText;

    private int scoreNum;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreNum = 0;
        myScoreText.text = "Score: " + scoreNum;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Coin")
        {
            Debug.Log("collision");
            scoreNum++;
            Destroy(col.gameObject);
            myScoreText.text = "Score: " + scoreNum;
        }
    }
}
