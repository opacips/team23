using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ItemDisplay : MonoBehaviour
{
    public ItemTemplate itemTemp;

    public SpriteRenderer sprRend;


    // Start is called before the first frame update
    void Start()
    {
        sprRend = GetComponent <SpriteRenderer>();
        sprRend.sprite = itemTemp.artwork;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

