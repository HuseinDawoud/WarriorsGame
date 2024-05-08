using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public float TimeControl;
    public float TimeTruth;
    void Start()
    {
        TimeTruth = Time.timeScale;
    }


    public void OnClick()
    {
        StartCoroutine(SpeedUping());
    }
    IEnumerator SpeedUping()
    {
        Time.timeScale = TimeControl;
        yield return new WaitForSeconds(150f);
        Time.timeScale = TimeTruth;
        yield break;
    }
}
