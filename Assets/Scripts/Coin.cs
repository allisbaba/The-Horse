using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Coin : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public int coinScore = 0;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            coinScore++;
            coinText.text = coinScore.ToString();
            Destroy(gameObject);
        }
    }
}
