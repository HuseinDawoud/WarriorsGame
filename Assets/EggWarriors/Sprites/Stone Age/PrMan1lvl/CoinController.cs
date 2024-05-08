
using System.Collections;
using UnityEngine;




public class CoinController : MonoBehaviour
{
    private int CoinPerBattle;
    public int CoinValue;
    public Sprite Coin;
    public Sprite HandFullCoin;
    public Sprite BagCoin;
    public SpriteRenderer ImgObject;
    private GameObject Bank;
    private float stoppingdistance;
    private float speed;
  

    private void Start()
    {

        stoppingdistance = 0.5f;
        speed = 5f;
    }
    private void Update()
    {   CoinValue = GetComponentInParent<DeletParent>().Coast;
        SpriteChanger();
        StartCoroutine(GoToBank());
        Bank = GameObject.Find("CoinPerBattle");
        
    }
    void SpriteChanger()
    {
        if (CoinValue <= 60)
        {
          ImgObject.sprite = Coin;
        }
         
        if (CoinValue <= 200 && CoinValue > 60)
        {
            ImgObject.sprite = HandFullCoin;
        } 
        if (CoinValue > 200)
        {
            ImgObject.sprite = BagCoin;
        }


    }
    IEnumerator GoToBank()
    {
        yield return new WaitForSeconds(3f);
       
        
        transform.position = Vector2.MoveTowards(transform.position, Bank.transform.position, speed * Time.deltaTime);
        
        if (Vector2.Distance(transform.position, Bank.transform.position) <= stoppingdistance)
        {
            
            transform.position = this.transform.position;
            Destroyer();
        }
        yield break;
    }
   private  void Destroyer()
    {
        CoinPerBattle = PlayerPrefs.GetInt("CoinBattle");
        CoinPerBattle += CoinValue;
        PlayerPrefs.SetInt("CoinBattle", CoinPerBattle);
        Destroy(gameObject);
    }
}