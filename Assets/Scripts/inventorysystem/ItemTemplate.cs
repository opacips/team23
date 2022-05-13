using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="New Item", menuName ="Inventory/Item")]
public class ItemTemplate : ScriptableObject
{
    public new string name;
    public string description;
    public Sprite icon;
    public bool IsDefaultItem;
    public bool isCollettable;


    public Sprite artwork;

    public int growthTime;
    public int hungerFill;

}

