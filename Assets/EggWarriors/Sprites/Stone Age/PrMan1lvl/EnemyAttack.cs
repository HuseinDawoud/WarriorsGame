using UnityEngine;

public class EnemyAttack : MonoBehaviour
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
            try
            {
              enemiesToDamage[0].GetComponent<Friend>().TakeDamage(damagef);
            }
            catch
            { 
                enemiesToDamage[0].GetComponent<FriendBase>().TakeDamage(damagef);
            }
           


        }
       
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPose.position, attackRange);
    }
}
