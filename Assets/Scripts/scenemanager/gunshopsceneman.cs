using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gunshopsceneman : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D col)
    {
       SceneManager.LoadScene("gunshopinside");
    }
}
