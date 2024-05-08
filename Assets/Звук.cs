using UnityEngine;
using UnityEngine.UI;


public class Звук : MonoBehaviour
{
    [Header("Sprite")]
    [SerializeField] private SpriteRenderer Sprite;

    [Header("Image")][SerializeField] private Image img;

    [Header("Sprites")]
    [SerializeField] private Sprite sprite;
    [SerializeField] private Sprite sprite1;


    public void ChangeSprite()
    {
        Sprite.sprite = sprite;

        img.sprite = sprite1;
    }
}
