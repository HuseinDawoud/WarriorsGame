using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPause : MonoBehaviour
{
    public float TimeControl;
    public float TimeTruth;
    void Start()
    {
        TimeTruth = 1;
    }


    public void OnClick()
    {
     Time.timeScale = TimeControl;
    }

    public void OnClick1()
    {
        Time.timeScale = TimeTruth;
    }

}