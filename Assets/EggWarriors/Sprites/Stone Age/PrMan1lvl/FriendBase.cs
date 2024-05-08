using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;




public class FriendBase : MonoBehaviour
{
    public int HP;
    public int MaxHealth;
    public Slider hpstat;
    public GameObject effect;
    public Text HPText;
    public GameObject Soldier;
    private int SoldierCount;
    public Transform parent;
    public GameObject DefeatPanel;



    private void Start()
    {
        HP = MaxHealth;
        hpstat.value = MaxHealth;
    }
    private void Update()
    {
        HPText.text = HP.ToString();

        hpstat.value = HP;

        TagChanger();
    }


    public void TakeDamage(int damagef)
    {
        HP -= damagef;
        Instantiate(effect, transform.position, Quaternion.identity);
        hpstat.value = HP;
        if (HP <= 0)
        {
            DefeatPanel.gameObject.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }

    void TagChanger()
    { 
        GameObject[] soldier = GameObject.FindGameObjectsWithTag("Friend");
        SoldierCount = soldier.Length;
        if (SoldierCount <= 1)
        {
            gameObject.tag = ("Friend");

        }
        else if (SoldierCount > 1) 
        {
            gameObject.tag = ("FriendBase");
        }
    }

}
