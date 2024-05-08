using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletParent : MonoBehaviour
{
    public int Coast;
    // Update is called once per frame
    void Update()
    {
        try
        {
         Coast = GetComponentInChildren<Enemy>().Coast;
        }
        catch
        {

        }
        if (gameObject.transform.childCount <= 0)
        {

            Destroy(gameObject);
        }
    }
}
