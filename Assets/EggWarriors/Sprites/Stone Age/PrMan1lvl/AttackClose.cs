using Unity.VisualScripting;
using UnityEngine;

public class AttackClose : MonoBehaviour
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

    public void Attack()
    {
        if (_anim.GetFloat("RunTG") == 1)
        {
            Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPose.position, attackRange, WhatIsEnemy);
            enemiesToDamage[0].GetComponent<Enemy>().TakeDamage(damagef);
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPose.position, attackRange);
    }
}
