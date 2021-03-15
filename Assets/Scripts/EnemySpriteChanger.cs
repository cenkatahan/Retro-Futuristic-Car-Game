using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpriteChanger : MonoBehaviour
{
    //This script chooses a spite for enemy cars randomly

    public Sprite[] cars;
    private int randomSprite;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();

        //choosing a sprite and assaigning it
        randomSprite = Random.Range(0, 4);
        spriteRenderer.sprite = cars[randomSprite];
    }

}
