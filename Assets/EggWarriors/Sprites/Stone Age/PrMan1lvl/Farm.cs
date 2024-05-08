using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class Farm : MonoBehaviour
{
    public GameObject particle;
    public Transform particlepos;
    public int MeatTotal;
    public float DeletingCount;
    private float i;
    public int b;
    public GameObject Upgrade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       i = PlayerPrefs.GetFloat("UpgradeF");
        MeatTotal = PlayerPrefs.GetInt("meatTotal");
        if (i >= 64)
        {
            DeletingCount = 0.1f;
        }
        else
        {
            DeletingCount = 0.5f;
        }
        b = Upgrade.GetComponent<UpgradeFarm>().LVL;

    }
   public void Particles()
    {
        StartCoroutine(ParticalesLife());
    }
   IEnumerator ParticalesLife()
    {
        Instantiate(particle, particlepos.position, Quaternion.identity,particlepos);
        MeatTotal++;
        Farmer();
        yield return new WaitForSeconds(DeletingCount);
    }
    public void Farmer()
    { if (b <= 4)
        {
         int meat = PlayerPrefs.GetInt("meat");
        meat++;
        PlayerPrefs.SetInt("meat", meat);
        }
    else if (b > 4)
        {
            int meat = PlayerPrefs.GetInt("meat");
            meat += b;
            PlayerPrefs.SetInt("meat", meat);
        }
       
    }
}
