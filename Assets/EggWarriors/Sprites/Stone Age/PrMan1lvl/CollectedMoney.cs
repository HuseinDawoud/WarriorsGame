using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectedMoney : MonoBehaviour
{
    int CoinBattle;
    public Text CollectedMoneyText;


    void Start()
    {
        
    }
 

    void Update()
    {

        CoinBattle = PlayerPrefs.GetInt("CoinBattle");
       CollectedMoneyText.text = CoinBattle.ToString();
        
    }
}


