using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class CoastMeat : MonoBehaviour
{
    public int Coast;
    public Text CoastText;
    public int Meat;
    public Button Button;

    
    // Update is called once per frame
    void Update()
    {

        Meat = PlayerPrefs.GetInt("meat");
        
        CoastText.text = Coast.ToString();
        if (Coast <= Meat)
        {
            Button.transform.localScale = new Vector3(0.66f, 34.025f, 1f);
            Button.interactable = true;
        }
        else
        {
            Button.interactable = false;
            Button.transform.localScale = new Vector3(0.6f,30f,1f);
        }

    }
    public void OnClicked()
    {
        Meat -= Coast;
        PlayerPrefs.SetInt("meat", Meat);
    }
}
