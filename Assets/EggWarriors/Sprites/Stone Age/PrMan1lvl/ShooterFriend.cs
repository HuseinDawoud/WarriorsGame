using System.Collections;
using System.Threading;
using UnityEngine;

public class ShooterFriend: MonoBehaviour
{
    public float range = 4;
    public GameObject proJEctile;
    public Transform parent;
    public GameObject Imitt; 
    public Animator _anim;
    private Transform enemy;
 

    private void Start()
    {
        _anim = GetComponent<Animator>();

    }
    private void Update()
    {
        Imitt.transform.position = Imitt.transform.position;
       
        
    }



    public void SearchTarget()
    {

        Transform nearestEnemy1 = null;
        float nearestEnemy1Distance = Mathf.Infinity;
        foreach (GameObject enemy1 in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            float CurrDistance1 = Vector2.Distance(transform.position, enemy1.transform.position);
            if (CurrDistance1 < nearestEnemy1Distance && CurrDistance1 <= range)
            {
                nearestEnemy1 = enemy1.transform;
                nearestEnemy1Distance = CurrDistance1;

            }
            else if (CurrDistance1 > nearestEnemy1Distance && CurrDistance1 >= range)
            {

            }
        }
        if (nearestEnemy1 != null)
        {
            Shoot(nearestEnemy1);
            DisActive();
        }
        else if (nearestEnemy1 == null) 
        { 
                _anim.SetFloat("RunTG", 5);
        }

        void Shoot(Transform enemy1)
        {
            GameObject proJ = Instantiate(proJEctile, Imitt.transform.position, Quaternion.identity, parent);
           
            proJ.transform.position = Imitt.transform.position;
            proJ.GetComponent<ProjecTileFriend>().SetTarget(enemy1);

        }

    }
    public void DisActive()
    {
        
      Imitt.gameObject.SetActive(false);
      
    }
    public void Activ()
    {
        Imitt.gameObject.SetActive(true);
    }
}
