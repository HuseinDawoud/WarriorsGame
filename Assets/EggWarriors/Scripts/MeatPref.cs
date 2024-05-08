using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeatPref : MonoBehaviour
{
    [SerializeField] int Meat;
    public Text MeatText;
    public int MeatTotal;
    void Start()
    {
        Meat = 50;
        PlayerPrefs.SetInt("meat", Meat);
    }
     public void Farming()
    {
        MeatTotal++;
        Meat++;
        PlayerPrefs.SetInt("meat", Meat);
        PlayerPrefs.SetInt("meatTotal", MeatTotal);
    }
    // Update is called once per frame
    void Update()
    {
        MeatText.text = Meat.ToString();
       Meat = PlayerPrefs.GetInt("meat");
       MeatTotal = PlayerPrefs.GetInt("meatTotal");
    }
}
