using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class money : MonoBehaviour
{
    private int _money= 450;
    public Text _moneyTXT;

    public void Awake(){
        

       _moneyTXT.text=_money.ToString();



    }
    public void Buy(){
        if(_money>=35){
            _money-=35;
            _moneyTXT.text=_money.ToString();
        }
        else{
            Debug.Log("para yok");
        }


    }




}
