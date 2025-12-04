using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catch : MonoBehaviour
{
    private GameObject item;
    [NonSerialized]
    public bool isCatch = false;
    
    void Update()
    {
        if (isCatch)
        {
            item.transform.position = gameObject.transform.position;
            item.transform.rotation = gameObject.transform.rotation;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Detail"))
        {
            item = other.gameObject;
            isCatch = true;
        }
    }
}
