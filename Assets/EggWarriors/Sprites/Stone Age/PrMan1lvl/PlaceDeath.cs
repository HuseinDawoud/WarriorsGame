using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceDeath : MonoBehaviour
{
    SpriteRenderer sprite;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        Color color = sprite.material.color;
        color.a = 1f;
        StartCoroutine(Inviz());
        StartCoroutine(Destroyer());
    }

 
    IEnumerator Inviz()
    {
        for (float f = 1f; f >= 0.05; f -= 0.05f)
        {
            Color color = sprite.material.color;
            color.a = f;
            sprite.material.color= color;
            yield return new WaitForSeconds(1f);
           
        }
    }
    IEnumerator Destroyer()
    {
        yield return new WaitForSeconds(10.2f);
        Destroy(gameObject);

    }

}
