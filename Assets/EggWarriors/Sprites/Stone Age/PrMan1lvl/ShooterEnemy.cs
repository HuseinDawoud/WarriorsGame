using System.Collections;
using System.Threading;
using UnityEngine;

public class ShooterEnemy : MonoBehaviour
{
    public float range = 4;
    public GameObject proJEctile;
    public Transform parent;
    public GameObject Imitt;
    private Animator _anim;
    private Transform enemy;

    private void Start()
    {
        _anim = GetComponent<Animator>();

    }
    private void Update()
    {
        try
        {
            _anim.SetFloat("RunTGSE", 1);
        }
        catch { }
        Imitt.transform.position = Imitt.transform.position;
    }



    public void SearchTarget()
    {

        Transform nearestEnemy = null;
        float nearestEnemyDistance = Mathf.Infinity;
        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Friend"))
        {
            float CurrDistance = Vector2.Distance(transform.position, enemy.transform.position);
            if (CurrDistance < nearestEnemyDistance && CurrDistance <= range)
            {
                nearestEnemy = enemy.transform;
                nearestEnemyDistance = CurrDistance;

            }
            else if (CurrDistance > nearestEnemyDistance && CurrDistance >= range)
            {

            }
        }
        if (nearestEnemy != null)
        {



            Shoot(nearestEnemy);
            DisActive();
        }
        else if (nearestEnemy == null)
        {
            _anim.SetFloat("RunTG", 5);
            _anim.SetFloat("RunTGSE", 5);
            
        }

        void Shoot(Transform enemy)
        {

            GameObject proJ = Instantiate(proJEctile, Imitt.transform.position, Quaternion.identity, parent);

            proJ.transform.position = Imitt.transform.position;
            proJ.GetComponent<ProjecTileEnemy>().SetTarget(enemy);



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
