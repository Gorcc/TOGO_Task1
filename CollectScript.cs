using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectScript : MonoBehaviour
{
    public int score = 0;
    public Text ScoreText;
    void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag == "Collectable")
        {

            score = score + 1;
            ScoreText.text = score.ToString();
            Destroy(other.gameObject);
        }

        else if(other.gameObject.tag == "Obstacle")
        {
            score = score - 1;
            ScoreText.text = score.ToString();
            Destroy(other.gameObject);
        }

    }


    void Update()
    {
        
    }
}
