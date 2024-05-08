using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwnObj : MonoBehaviour
    
{
    public GameObject objectt;
    public Transform  posSpwn;
    public Transform parent;
    public int countFriend = 0;
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnObject()
    {

        Instantiate(objectt, posSpwn.position, Quaternion.identity, parent);
        //countFriend++;
        //Debug.Log(countFriend);
    }
      
}
