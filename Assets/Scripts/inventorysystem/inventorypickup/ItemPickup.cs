using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : InteractableTemplate
{
    public ItemTemplate item;
    public bool isStable;


    private void Start()
    {
        isStable = true;
    }
    public override void Interactable()
    {
        base.Interactable();

        PickUp();
    }
    void Update()
    {
        if (isStable == true)
        {

        } 
    }

    void PickUp()
    {
        Debug.Log("Item Alınıyor." + item.name);
        bool wasPickedUp = Inventory.instance.Add(item);// npc den satın alırken ekle

        if (wasPickedUp)
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>() != null)
        {
            isStable = false;
            transform.position = Vector2.Lerp(transform.position, collision.transform.position, 6f * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PickUp();
        }
    }
    public void ItemPickupI()
    {
        bool wasPickedUp = Inventory.instance.Add(item);
        if (wasPickedUp)
        {
           
        }

    }
    
}
