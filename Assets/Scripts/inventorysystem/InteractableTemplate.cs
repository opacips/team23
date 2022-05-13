using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTemplate : MonoBehaviour
{

    public float radius = 1.20f;



    public virtual void Interactable()
    {
        Debug.Log("zazu");

    }

    void Start()
    {

    }

    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }


    // Update is called once per frame 
    void Update()
    {

    }
}
