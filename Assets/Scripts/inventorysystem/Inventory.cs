using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
     public static Inventory instance;
    public delegate void OnItemChanged();
    public OnItemChanged OnItemChangedCallback;

    public int space = 30;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Birden fazla envanter");
            return;
        }

        instance = this;
    }

    

    public List<ItemTemplate> items = new List<ItemTemplate>();

    public bool Add(ItemTemplate item)
    {
        if (!item.IsDefaultItem)
        {
            if(items.Count >= space)
            {
                Debug.Log("Yer yok.");
                return false;
            }
            items.Add(item);
            if (OnItemChangedCallback != null)
            {
                OnItemChangedCallback.Invoke();
            }
        }
        return true;
    }


    public void Remove(ItemTemplate item)
    {
        items.Add(item);
        if (OnItemChangedCallback != null)
        {
            OnItemChangedCallback.Invoke();
        }
    }
}
