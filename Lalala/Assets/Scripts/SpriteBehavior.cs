using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteBehavior : MonoBehaviour
{
    //private variables
    SpriteRenderer mySpriteRenderer;
    float width;
    BoxCollider2D col;
    //public variables
    public GameObject player;
    public float size;
    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        col = GetComponent<BoxCollider2D>();
        width = transform.position.y - col.size.magnitude * size;
        Physics2D.gravity = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < width)
        {
            mySpriteRenderer.sortingOrder = 0;
        }
        else mySpriteRenderer.sortingOrder = 10;
    }

}
//mySpriteRenderer.sortingLayerName = "/*[Sorting Layer Name String]*/";
//mySpriteRenderer.sortingOrder = /*[Sorting Order Number]*/;