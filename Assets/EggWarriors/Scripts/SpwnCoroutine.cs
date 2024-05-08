using System.Collections;
using System.Collections.Generic;
using TMPro.Examples;
using UnityEngine;

public class SpwnCoroutine : MonoBehaviour
{
    public GameObject objectt;
    public GameObject objectt2;
    public GameObject objectt3; 
    public GameObject objectt4;
    public Transform posSpwn;
    public Transform posSpwn2;
    public Transform parent;
    void Start()
    {
        StartCoroutine(SpawnEnemyes());
        Instantiate(objectt, posSpwn.position, Quaternion.identity, parent);
        Instantiate(objectt, posSpwn.position, Quaternion.identity, parent);
    }
    void Reapeat()
    {
        StartCoroutine(SpawnEnemyes());
       
    }
    IEnumerator SpawnEnemyes()
    { yield return new WaitForSeconds(15f);

        Instantiate(objectt, posSpwn.position, Quaternion.identity, parent);
        Instantiate(objectt, posSpwn.position, Quaternion.identity, parent);
        Instantiate(objectt3, posSpwn.position, Quaternion.identity, parent);
        Instantiate(objectt3, posSpwn.position, Quaternion.identity, parent);
        yield return new WaitForSeconds(15f);

        Instantiate(objectt2, posSpwn.position, Quaternion.identity, parent);
        yield return new WaitForSeconds(30f);
        Instantiate(objectt4, posSpwn2.position, Quaternion.identity, parent);
        Reapeat();
    }
    
}

