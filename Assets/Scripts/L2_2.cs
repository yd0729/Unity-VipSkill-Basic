using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L2_2 : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite sprite;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite;  // 变成 🥦
        spriteRenderer.color = Color.black;  // 变成黑色
        spriteRenderer.flipX = true;
    }

    // Update is called once per frame
}
