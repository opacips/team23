using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class marketsceneman : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D col)
    {
       SceneManager.LoadScene("marketinside");
    }
}
