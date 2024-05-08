using UnityEngine;
using UnityEngine.UI;


public class UpgradeFarm : MonoBehaviour
{
    public GameObject MainCharachter;
    private float UpgradeF;
    public Button Button;
    public int Coast1LVL;  
    public int Coast2LVL;  
    public int Coast3LVL;   
    public int Coast4LVL;  
    public int Coast5LVL;  
    public int Coast6LVL;  
    public int Coast7LVL;
    public int LVL;
    public int CoinBattle;
    private int meat;
    public int CoastUpgrade;
    public Text CoastUpgradeText; 
    public Text LVLText;
    void Start()
        {
        UpgradeF = MainCharachter.GetComponent<Animator>().GetFloat("Speed");
        PlayerPrefs.SetFloat("UpgradeF", UpgradeF);
        Button = gameObject.GetComponent<Button>();
        LVL = 1;
    }
    public void Upgrade()
    {   if (LVL < 4)
        {
            UpgradeF = MainCharachter.GetComponent<Animator>().GetFloat("Speed");
            UpgradeF /= 0.5f;
            MainCharachter.GetComponent<Animator>().SetFloat("Speed", UpgradeF);
            PlayerPrefs.SetFloat("UpgradeF", UpgradeF);
        }
        LVL++;
        meat += 150;
        CoinBattle -= CoastUpgrade; 
        PlayerPrefs.SetInt("CoinBattle", CoinBattle);
        PlayerPrefs.SetInt("meat", meat);
    }
    public void Update()
    { 
       CoinBattle = PlayerPrefs.GetInt("CoinBattle");
        if (CoinBattle < CoastUpgrade)

        {
            Button.interactable = false;
        }
        else if (CoinBattle >= CoastUpgrade)
        {
            Button.interactable = true;
        }
        if (LVL == 1)
        {
            CoastUpgrade = Coast1LVL; ;
        }
        else

        if (LVL == 2)
        {
            CoastUpgrade = Coast2LVL; ;
        }
        else
        if (LVL == 3)
        {
            CoastUpgrade = Coast3LVL; ;
        }
        else
        if (LVL == 4)
        {
            CoastUpgrade = Coast4LVL; ;
        }
        else
        if (LVL == 5)
        {
            CoastUpgrade = Coast5LVL; ;
        }
        else 
        if (LVL == 6)
        {
            CoastUpgrade = Coast6LVL; ;
        }
        else
        if (LVL == 7)
        {
            CoastUpgrade = Coast7LVL; ;
        }
        else
        
        CoinBattle = PlayerPrefs.GetInt("CoinBattle");
        meat = PlayerPrefs.GetInt("meat");

        CoastUpgradeText.text = CoastUpgrade.ToString();
        LVLText.text = LVL.ToString();
    }
}
