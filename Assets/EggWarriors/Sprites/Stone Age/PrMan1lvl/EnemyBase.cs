using UnityEngine;
using UnityEngine.UI;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;


public class EnemyBase : MonoBehaviour
{
    public int HP;
    public int MaxHealth;
    public Slider hpstat;
    public GameObject effect;
    public Text HPText;
    private int SoldierCount;
    private int CoinBattle;
    public int CoastPerAttack;
    public GameObject WinPanel;

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
        CoinBattle = PlayerPrefs.GetInt("CoinBattle");
        CoinBattle += CoastPerAttack;
        PlayerPrefs.SetInt("CoinBattle", CoinBattle);
        HP -= damagef;
        Instantiate(effect, transform.position, Quaternion.identity);
        hpstat.value = HP;
        if (HP <= 0)
        {
            WinPanel.gameObject.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
    void TagChanger()
    {
        GameObject[] soldier = GameObject.FindGameObjectsWithTag("Enemy");
        SoldierCount = soldier.Length;
        if (SoldierCount <= 1)
        {
            gameObject.tag = ("Enemy");

        }
        else if (SoldierCount > 1)
        {
            gameObject.tag = ("EnemyBase");
        }
    }

}




