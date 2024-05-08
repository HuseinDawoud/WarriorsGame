using System;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMegaAttack : MonoBehaviour
{
    private Animator _anim;
    public Transform attackPose;
    public float attackRange;
    public LayerMask WhatIsEnemy;
    public int damagef;
    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    public void Attack()
    {


        if (_anim.GetFloat("RunTG") == 1)
        {
            Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPose.position, attackRange, WhatIsEnemy);
            for (int i = 0; i < enemiesToDamage.Length; i++)
            {

                try
                {
                    enemiesToDamage[i].GetComponent<Friend>().TakeDamage(damagef);
                }
                catch
                {
                    enemiesToDamage[i].GetComponent<FriendBase>().TakeDamage(damagef);
                }
            }


        }

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPose.position, attackRange);
    }
}