using HardLight2DUtil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TesstSpire : MonoBehaviour
{
    private Animator _anim;
    public Transform attackPose;
    public float attackRange;
    public LayerMask WhatIsEnemy;
    public int damagef;
    public GameObject Projectile;
    public GameObject target;
    public float speed;
    public bool Moved;
    private float CurrDistance;

    void Start()
    {
        Moved = false;
    }

   
    void Update()
    {

        if (Moved == true )
        {
          
            Projectile.transform.position = Vector2.MoveTowards(Projectile.transform.position, target.transform.position, speed * Time.deltaTime);
           
        }
        SearchTarget();
        Projectile = transform.Find("Circle").gameObject;
        if (target != null)
        {
            gameObject.GetComponent<Animator>().SetFloat("RunTG", 5);
        }
        else
        {
            gameObject.GetComponent<Animator>().SetFloat("RunTG", 1);
        }


    }
       
   void SearchTarget()
    {
        Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPose.position, attackRange, WhatIsEnemy);
        target = enemiesToDamage[0]. gameObject;
         
    }
    public void OnAttack()
    {
       
       
        if (target != null )
        {
             Moved = true;
           
            if (Vector2.Distance(Projectile.transform.position, target.transform.position) < (0.1f))
            {  
                
                Destroy(Projectile);
                Moved = false;
               
                target.GetComponent<Enemy>().TakeDamage(damagef);
            }
            
        }

       
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPose.position, attackRange);
    }
}
