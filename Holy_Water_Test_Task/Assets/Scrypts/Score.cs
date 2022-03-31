using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text coinCount;

    public int score = 0;

    private void Start()
    {
        coinCount.text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            Destroy(other.gameObject);
            score++;
            coinCount.text = score.ToString();
        }
    }
}
