using UnityEngine;
using UnityEngine.Animations;

public class ProjecTileFriend : MonoBehaviour
{
    Transform target;
    float speed = 7;
    public int damagef = 10;
    public float offset;
    void Update()
    {
        Move();
        
            foreach (GameObject enemy1 in GameObject.FindGameObjectsWithTag("Enemy")) ;
        try
        {
          var direction = target.position - this.transform.position;
          // var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
          // this.transform.rotation = Quaternion.Euler(0f, 0f, angle + offset);
           }
        catch { }
        }
       
    public void SetTarget(Transform enemy1)
    {
       
         target = enemy1;
      
    }
    private void Move()
    {
        if (target != null)
        {
            if (Vector2.Distance(transform.position,target.position) <= (0.1f))
            {
                DestroyProjecTile();
            }
            else
            {
                Vector2 dir = target.position - transform.position ;
                transform.Translate(dir.normalized * Time.deltaTime * speed);
            }
        }
        else
            DestroyProjecTile();
    }
    void DestroyProjecTile()
    {
        if (gameObject != null && target != null)
        { 
        Destroy(gameObject);
        try
        {
            target.GetComponent<Enemy>().TakeDamage(damagef);
        }
        catch
        {
            target.GetComponent<EnemyBase>().TakeDamage(damagef);
        }
        }
        else if (gameObject != null && target == null)
        {  Destroy(gameObject);}
    }
        
}

