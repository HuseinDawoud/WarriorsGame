using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonKnock : MonoBehaviour
{
    public AudioSource soundPlay;

    public void PlayThisSoundEffect()
    {
        soundPlay.Play();
    }

}
