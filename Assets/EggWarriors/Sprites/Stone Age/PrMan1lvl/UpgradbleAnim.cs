using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UpgradbleAnim : MonoBehaviour
{
    public GameObject MainCharachter;
    private float UpgradeF;


    void Start()
    {
        UpgradeF = MainCharachter.GetComponent<Animator>().GetFloat("Speed");
        
    }
    void Update()
    {
        UpgradeF = MainCharachter.GetComponent<Animator>().GetFloat("Speed");
        gameObject.GetComponent<Animator>().SetFloat("Speed1", UpgradeF);
       
    }
}