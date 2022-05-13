using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopcol : MonoBehaviour
{
    public GameObject _shopopen,_inventoryopen;

    public void OnCollisionEnter2D(Collision2D col)
    {
    
       _shopopen.SetActive(true);
       _inventoryopen.SetActive(true);
    }
    public void OnCollisionExit2D(Collision2D col)
    {
       _shopopen.SetActive(false);
       _inventoryopen.SetActive(false);
    }
}
