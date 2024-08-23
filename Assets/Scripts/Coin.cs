using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Coin : MonoBehaviour
{
   
    
    public int coinScore = 0;
   
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            coinScore++;
            Debug.Log("skor arttý obje yok oldu");
            CoinMaster.instance.coinText.text = coinScore.ToString();
            Destroy(gameObject);
        }
    }
}
