using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InventoryDisplay7 : MonoBehaviour
{
     public ItemTemplate item;
    public GameObject ab,image;
    public Sprite test;
    public Button bttn;
    ItemPickup alabama;

    void Start()
    {
        alabama = GetComponent<ItemPickup>();
        bttn = GetComponent<Button>();
        ab = GameObject.FindGameObjectWithTag("NPC");
        test = ab.GetComponent<NPC>().items[7].artwork;
        item = ab.GetComponent<NPC>().items[7];
        //bttn.GetComponent<Image>().sprite = test;
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void patates(){
        image.GetComponent<Image>().sprite=test;

    }
    public void InventoryAdd()
    {
        alabama.item = item;
        alabama.ItemPickupI();
    }
}
