using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Transform enemy;
    private Animator _anim;
    private Rigidbody2D rb;
    public int HP;
    public int MaxHealth;
    public Slider hpstat;
    public float stoppingdistance;
    public GameObject effect;
    public GameObject DeathPlace;
    public GameObject Coin;
    public Transform parent;
    public int Coast;


    private void Start()
    {
        _anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        HP = MaxHealth;
        hpstat.value = MaxHealth;
    }
    void Update()
    {
        try
        {
            enemy = GameObject.FindGameObjectWithTag("Friend").transform;
        }
        catch
        {
            if (enemy == null)
            {
                transform.position = this.transform.position;
            }
        }
        if (enemy != null)
        {
            
            {
                if (hpstat.value < MaxHealth)
                {
                    hpstat.gameObject.SetActive(true);
                }
                else
                {
                    hpstat.gameObject.SetActive(false);
                }
            }
            if (Vector2.Distance(transform.position, enemy.position) > stoppingdistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, enemy.position, speed * Time.deltaTime);
                _anim.SetFloat("RunTG", 5);
                speed = 0.1f;
                rb.mass = 1;
                 void OnTriggerExit2D(Collider2D collision)
                {
                    if (collision.CompareTag("Friend"))
                    {
                        speed = 0.1f;
                        _anim.SetFloat("RunTG", 5);
                        rb.mass = 1;
                    }
                }
            }

            else if (Vector2.Distance(transform.position, enemy.position) <= stoppingdistance)
            {
                transform.position = this.transform.position;
                _anim.SetFloat("RunTG", 1);
                speed = 0;
                rb.mass = 100000;
                void OnTriggerEnter2D(Collider2D collision)
                {
                    if (collision.tag == ("Friend"))
                    {
                        speed = 0f;
                        _anim.SetFloat("RunTG", 1);
                        rb.mass = 100000;
                    }
                }
            }
        }
    }
    public void TakeDamage(int damagef)
    {
        HP -= damagef;
        Instantiate(effect, transform.position, Quaternion.identity);    
        hpstat.value = HP;
        if (HP <= 0)
        {
            Instantiate(Coin, transform.position, Quaternion.identity,parent);
            Instantiate(DeathPlace, transform.position, Quaternion.identity, parent);
            Destroy(gameObject);
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Friend"))
        {
            speed = 0f;
            _anim.SetFloat("RunTG", 1);
            rb.mass = 100000;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Friend"))
        {
            speed = 0.1f;
            _anim.SetFloat("RunTG", 5);
            rb.mass = 1;
        }
    }



}