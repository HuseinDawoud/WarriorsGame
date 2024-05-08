//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    public Sprite onMusic;
    public Sprite offMusic;

    public Image MusicButton;
    public bool isOn;
    public AudioSource ad;



    void Start()
    {
        PlayerPrefs.GetInt("music");
        {
            if (PlayerPrefs.HasKey("music") == false)
            {
                isOn = true;
                    }
            else
                {
               //
                }
            }           
       



    }
    void Update()
    {
        if (PlayerPrefs.GetInt("music") == 0)
        {
            MusicButton.GetComponent<Image>().sprite = onMusic;
            ad.enabled = true;
            isOn = true;
        }
        else if (PlayerPrefs.GetInt("music") == 1)
        {
            MusicButton.GetComponent<Image>().sprite = offMusic;
            ad.enabled = false;
            isOn = false;
        }
    }


    public void offSaund()
    {
        if (!isOn)
        {
            PlayerPrefs.SetInt("music", 0);

        }
        else if (isOn)
        {
            PlayerPrefs.SetInt("music", 1);
        

        }
        PlayerPrefs.Save();
    }


}