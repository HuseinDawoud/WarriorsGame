using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeatBonus : MonoBehaviour
{
    public int Coast;
    public Text CoastText;
    public int Meat;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Meat = PlayerPrefs.GetInt("meat");
        CoastText.text = Coast.ToString();

    }
    public void OnClicked()
    {
        Meat += Coast;
        PlayerPrefs.SetInt("meat", Meat);
    }
}
