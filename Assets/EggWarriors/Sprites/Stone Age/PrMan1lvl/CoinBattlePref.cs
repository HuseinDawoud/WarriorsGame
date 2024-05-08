using UnityEngine;
using UnityEngine.UI;

public class CoinBattlePref : MonoBehaviour
{

    int CoinBattle;
    public Text CoinBattleText;


    void Start()
    {
        CoinBattle = 0;
        PlayerPrefs.SetInt("CoinBattle", CoinBattle);
    }
    //public void Farming()
    //{
        
        
    //    PlayerPrefs.SetInt(" CoinBattle", CoinBattle);
       
    //}

    void Update()
    {
        
        CoinBattle = PlayerPrefs.GetInt("CoinBattle");
        CoinBattleText.text = CoinBattle.ToString();
    }
}



