using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class LookAtme : MonoBehaviour
{
    public float speed = 7f;
    public int damagef = 10;
    public Transform enemy;
    private Animator _anim;
    public float offset;

    void Update()
    {

        try
        {
          enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        
      
           var direction = enemy.position - this.transform.position;
           var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
          this.transform.rotation = Quaternion.Euler(0f, 0f, angle + offset);
        }
        catch
        { }
           
       
    }


    public void Shoot()
    {
        
    }

}


   
