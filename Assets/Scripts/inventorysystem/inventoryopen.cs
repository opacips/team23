using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventoryopen : MonoBehaviour
{
    public GameObject _inventorybutton;
    public GameObject _inventoryimage;
    public GameObject _shopexit;
    public void InventoryOpen(){
       _inventoryimage.SetActive(true);
       
       _inventorybutton.SetActive(false);




    }
    public void InventoryExit(){
        _inventoryimage.SetActive(false);
        _inventorybutton.SetActive(true);
        
        _shopexit.SetActive(false);
    }
}
