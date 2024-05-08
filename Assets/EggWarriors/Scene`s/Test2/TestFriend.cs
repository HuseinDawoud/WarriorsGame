using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFriend : MonoBehaviour
{

    private GameObject Enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
         while (Enemy != null)
        {
            transform.position = Enemy.transform.position;
        }
        
    }
}
