using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveto : MonoBehaviour
{
    public GameObject target;
    
    void Update()
    {
    transform.position = Vector2.Lerp(transform.position,target.transform.position, Time.deltaTime);
 }
}
