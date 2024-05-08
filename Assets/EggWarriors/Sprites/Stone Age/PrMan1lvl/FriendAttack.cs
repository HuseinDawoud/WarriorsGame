using System;
using UnityEngine;

public class FriendAttack : MonoBehaviour
{
    private  Animator _anim;
    public Transform attackPose;
    public float attackRange;
    public LayerMask WhatIsEnemy;
    public int damagef;
    private void Start()
    {
        _anim = GetComponent<Animator>();
    }
    
    private void Update()
    {
       
        
            if (_anim.GetFloat("RunTG") == 1)
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPose.position, attackRange,WhatIsEnemy);
            try
            {
                enemiesToDamage[0].GetComponent<Enemy>().TakeDamage(damagef);
            }
            catch
            {
                enemiesToDamage[0].GetComponent<EnemyBase>().TakeDamage(damagef);
            }
        }
        
    }
     void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPose.position, attackRange);
    }
}



  
