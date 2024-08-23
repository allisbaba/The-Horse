using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinMaster : MonoBehaviour
{
    public static CoinMaster instance;
    public TextMeshProUGUI coinText;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        
    }
}
